﻿using System;
using System.Runtime.InteropServices;

using SiliconStudio.Core.Mathematics;
using SiliconStudio.Xenko.Graphics;
using SiliconStudio.Xenko.Graphics.Internals;
using SiliconStudio.Xenko.Rendering;


namespace SiliconStudio.Xenko.Particles
{
    public partial class ParticleBatch : BatchBase<ParticleBatch.ParticleDrawInfo>
    {
        private Matrix transformationMatrix;

//        private Matrix viewMatrix;
//        private Matrix projMatrix;
        private Matrix invViewMatrix;
//        private Vector4 vector4UnitX = Vector4.UnitX;
//        private Vector4 vector4UnitY = -Vector4.UnitY;

        public ParticleBatch(GraphicsDevice device, int bufferElementCount = 1024, int batchCapacity = 64)
            : base(device, ParticleBatch.Bytecode, ParticleBatch.BytecodeSRgb, StaticQuadBufferInfo.CreateQuadBufferInfo("ParticleBatch.VertexIndexBuffer", true, bufferElementCount, batchCapacity), ParticleVertex.Layout)
        {
        }

        protected override void UpdateBufferValuesFromElementInfo(ref ElementInfo elementInfo, IntPtr vertexPointer, IntPtr indexPointer, int vexterStartOffset)
        {
            var emitter = elementInfo.DrawInfo.Emitter;

            var unitX = new Vector3(invViewMatrix.M11, invViewMatrix.M12, invViewMatrix.M13);
            var unitY = new Vector3(invViewMatrix.M21, invViewMatrix.M22, invViewMatrix.M23);

            var remainingCapacity = 2000;
            emitter.BuildVertexBuffer(vertexPointer, unitX, unitY, ref remainingCapacity);
        }

        public void Draw(Texture texture, ParticleEmitter emitter)
        {
            var drawInfo = new ParticleDrawInfo
            {
                Emitter = emitter,
            };

            // TODO Sort by depth
            float depthSprite = 1f;

            var totalParticles = emitter.pool.LivingParticles;

            var elementInfo = new ElementInfo(
                StaticQuadBufferInfo.VertexByElement * totalParticles, 
                StaticQuadBufferInfo.IndicesByElement * totalParticles, 
                ref drawInfo, 
                depthSprite);

            Draw(texture, ref elementInfo);

        }


        protected override void PrepareForRendering()
        {
            // TODO Setup my uniforms here

            // Setup the Transformation matrix of the shader
            Parameters.Set(ParticleBaseKeys.MatrixTransform, transformationMatrix);

            /*
            Parameters.Set(ParticleBaseKeys.ViewMatrix, viewMatrix);
            Parameters.Set(ParticleBaseKeys.ProjectionMatrix, projMatrix);

            Parameters.Set(ParticleBaseKeys.InvViewX, new Vector4(invViewMatrix.M11, invViewMatrix.M12, invViewMatrix.M13, 0));
            Parameters.Set(ParticleBaseKeys.InvViewY, new Vector4(invViewMatrix.M21, invViewMatrix.M22, invViewMatrix.M23, 0));
            //*/

            base.PrepareForRendering();
        }

        public void Begin(Matrix viewMat, Matrix projMat, Matrix viewInv, SpriteSortMode sortMode = SpriteSortMode.Deferred, BlendState blendState = null, SamplerState samplerState = null, DepthStencilState depthStencilState = null, RasterizerState rasterizerState = null, Effect effect = null, EffectParameterCollectionGroup parameterCollectionGroup = null, int stencilValue = 0)
        {
            CheckEndHasBeenCalled("begin");

            transformationMatrix = viewMat * projMat;
            invViewMatrix = viewInv;

            Begin(effect, parameterCollectionGroup, sortMode, blendState, samplerState, depthStencilState, rasterizerState, stencilValue);
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ParticleDrawInfo
        {
            public ParticleEmitter Emitter;
        }
    }
}
