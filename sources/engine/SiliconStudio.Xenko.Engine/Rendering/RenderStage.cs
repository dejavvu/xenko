using System.Collections.Generic;
using SiliconStudio.Core;
using SiliconStudio.Xenko.Graphics;

namespace SiliconStudio.Xenko.Rendering
{
    public class RenderStage
    {
        public string Name { get; }
        public string EffectSlotName { get; }

        /// <summary>
        /// Index in <see cref="RootRenderFeature.RenderStages"/>.
        /// </summary>
        public int Index = -1;

        public RenderStage(string name, string effectSlotName)
        {
            Name = name;
            EffectSlotName = effectSlotName;
        }

        /// <summary>
        /// Defines render targets this stage outputs to.
        /// </summary>
        [DataMemberIgnore]
        public RenderOutputDescription Output;

        public override string ToString()
        {
            return Name;
        }
    }
}