﻿#if SILICONSTUDIO_XENKO_GRAPHICS_API_OPENGLCORE
//------------------------------------------------------------------------------
// <auto-generated>
//     Xenko Effect Compiler File Generated:
//     Effect [SpriteSignedDistanceFieldFontShader]
//
//     Command Line: C:\work\Stash\Xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders093.Bytecodes\..\..\..\..\Bin\Windows-Direct3D11\SiliconStudio.Assets.CompilerApp.exe --profile=Windows-OpenGL --platform=Windows --output-path=C:\work\Stash\Xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders093.Bytecodes\obj\app_data --build-path=C:\work\Stash\Xenko\sources\engine\SiliconStudio.Xenko.Graphics\Shaders093.Bytecodes\obj\build_app_data --package-file=Graphics.xkpkg
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiliconStudio.Xenko.Graphics 
{
    internal partial class SpriteSignedDistanceFieldFontShader
    {
        private static readonly byte[] spriteSignedDistanceFieldFontBytecode = new byte[] {
3, 192, 254, 239, 0, 6, 0, 0, 0, 35, 83, 112, 114, 105, 116, 101, 83, 105, 103, 110, 101, 100, 68, 105, 115, 116, 97, 110, 99, 101, 70, 105, 101, 108, 100, 70, 111, 110, 116, 83, 104, 97, 100, 101, 114, 1, 176, 57, 69, 207, 239, 252, 141, 229, 243, 96, 11, 8, 151, 19, 109, 107, 10, 83, 112, 
114, 105, 116, 101, 66, 97, 115, 101, 1, 24, 122, 117, 12, 177, 182, 110, 250, 252, 51, 21, 105, 61, 219, 225, 104, 10, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 1, 76, 31, 25, 215, 193, 29, 168, 182, 119, 159, 125, 91, 210, 35, 12, 84, 16, 83, 104, 97, 100, 101, 114, 66, 97, 115, 101, 
83, 116, 114, 101, 97, 109, 1, 252, 149, 143, 37, 199, 91, 237, 34, 31, 232, 194, 67, 83, 107, 157, 134, 9, 84, 101, 120, 116, 117, 114, 105, 110, 103, 1, 90, 7, 144, 56, 150, 36, 71, 168, 103, 101, 181, 74, 154, 179, 90, 203, 23, 83, 105, 103, 110, 101, 100, 68, 105, 115, 116, 97, 110, 99, 
101, 70, 105, 101, 108, 100, 70, 111, 110, 116, 1, 225, 234, 103, 136, 234, 194, 89, 185, 46, 49, 20, 205, 65, 22, 28, 186, 0, 0, 2, 0, 0, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 3, 0, 0, 0, 4, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 64, 0, 0, 0, 1, 
1, 0, 26, 83, 112, 114, 105, 116, 101, 66, 97, 115, 101, 46, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 0, 20, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 0, 0, 0, 0, 64, 0, 0, 0, 1, 1, 0, 7, 80, 
101, 114, 68, 114, 97, 119, 64, 0, 0, 0, 1, 0, 0, 0, 0, 0, 11, 0, 0, 0, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 
101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 52, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 
0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 54, 8, 0, 0, 0, 
8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 
101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 56, 16, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 
114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 48, 24, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 
1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 101, 108, 83, 105, 
122, 101, 95, 105, 100, 50, 50, 32, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 53, 84, 
101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 53, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 52, 40, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 
0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 54, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 54, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 54, 48, 0, 0, 0, 8, 0, 0, 
0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 
117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 56, 56, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 
103, 46, 84, 101, 120, 116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 48, 64, 0, 0, 0, 8, 0, 0, 0, 1, 1, 1, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 
0, 2, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0, 1, 1, 0, 27, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 0, 22, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 
105, 100, 51, 50, 72, 0, 0, 0, 8, 0, 0, 0, 1, 1, 13, 0, 0, 0, 3, 0, 0, 0, 1, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 16, 0, 0, 0, 1, 1, 0, 41, 83, 112, 114, 105, 116, 101, 83, 105, 103, 110, 101, 100, 68, 105, 115, 116, 97, 110, 99, 101, 70, 105, 
101, 108, 100, 70, 111, 110, 116, 83, 104, 97, 100, 101, 114, 46, 67, 111, 108, 111, 114, 0, 10, 67, 111, 108, 111, 114, 95, 105, 100, 55, 51, 80, 0, 0, 0, 16, 0, 0, 0, 1, 1, 0, 7, 71, 108, 111, 98, 97, 108, 115, 96, 0, 0, 0, 1, 0, 0, 0, 0, 4, 0, 0, 0, 0, 
18, 84, 101, 120, 116, 117, 114, 105, 110, 103, 46, 84, 101, 120, 116, 117, 114, 101, 48, 9, 0, 0, 0, 7, 0, 0, 0, 0, 13, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 17, 84, 101, 120, 116, 117, 114, 
105, 110, 103, 46, 83, 97, 109, 112, 108, 101, 114, 8, 0, 0, 0, 10, 0, 0, 0, 0, 12, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 1, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 7, 80, 101, 114, 68, 114, 97, 119, 10, 0, 0, 0, 26, 0, 0, 0, 
0, 7, 80, 101, 114, 68, 114, 97, 119, 0, 7, 80, 101, 114, 68, 114, 97, 119, 1, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 7, 71, 108, 111, 98, 97, 108, 115, 10, 0, 0, 0, 26, 0, 0, 0, 0, 7, 71, 108, 111, 98, 97, 108, 115, 0, 7, 71, 108, 111, 98, 97, 
108, 115, 5, 0, 0, 0, 255, 255, 255, 255, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 2, 0, 0, 0, 0, 1, 0, 0, 0, 0, 83, 4, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 52, 49, 48, 13, 10, 13, 10, 115, 116, 114, 
117, 99, 116, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 
100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 
32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 
116, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 
13, 10, 125, 59, 13, 10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 32, 117, 110, 105, 102, 111, 114, 109, 32, 80, 101, 114, 68, 114, 97, 119, 32, 123, 13, 10, 32, 32, 32, 32, 109, 97, 116, 52, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 
109, 95, 105, 100, 55, 50, 59, 13, 10, 125, 59, 13, 10, 111, 117, 116, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 52, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 105, 110, 32, 118, 101, 99, 
50, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 73, 78, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 
110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 97, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 
32, 61, 32, 97, 95, 80, 79, 83, 73, 84, 73, 79, 78, 48, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 
100, 55, 49, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 95, 48, 105, 110, 
112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 40, 115, 116, 114, 101, 97, 109, 115, 
46, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 55, 49, 32, 42, 32, 77, 97, 116, 114, 105, 120, 84, 114, 97, 110, 115, 102, 111, 114, 109, 95, 105, 100, 55, 50, 41, 59, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 
48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 
95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 
32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 
32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 61, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 122, 32, 
42, 32, 50, 46, 48, 32, 45, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 119, 59, 13, 10, 32, 32, 32, 32, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 32, 61, 32, 45, 103, 108, 95, 80, 111, 115, 105, 116, 105, 111, 110, 46, 121, 59, 13, 10, 125, 13, 10, 
1, 54, 163, 255, 32, 251, 184, 254, 217, 254, 1, 127, 61, 71, 187, 158, 98, 0, 5, 0, 0, 0, 0, 42, 10, 0, 0, 35, 118, 101, 114, 115, 105, 111, 110, 32, 52, 49, 48, 13, 10, 13, 10, 115, 116, 114, 117, 99, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 13, 10, 123, 
13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 
32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 125, 59, 13, 10, 115, 116, 114, 117, 99, 116, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 
13, 10, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 125, 59, 13, 
10, 108, 97, 121, 111, 117, 116, 40, 115, 116, 100, 49, 52, 48, 41, 32, 32, 117, 110, 105, 102, 111, 114, 109, 32, 71, 108, 111, 98, 97, 108, 115, 32, 123, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 48, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 
100, 49, 52, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 49, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 49, 54, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 50, 84, 101, 120, 101, 108, 83, 105, 
122, 101, 95, 105, 100, 49, 56, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 51, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 52, 84, 101, 120, 
101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 53, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 52, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 
54, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 54, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 55, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 50, 56, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 
116, 117, 114, 101, 56, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 48, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 50, 32, 84, 101, 120, 116, 117, 114, 101, 57, 84, 101, 120, 101, 108, 83, 105, 122, 101, 95, 105, 100, 51, 50, 59, 13, 10, 32, 32, 32, 32, 118, 101, 99, 52, 
32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 51, 59, 13, 10, 125, 59, 13, 10, 117, 110, 105, 102, 111, 114, 109, 32, 115, 97, 109, 112, 108, 101, 114, 50, 68, 32, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 59, 13, 
10, 108, 97, 121, 111, 117, 116, 40, 108, 111, 99, 97, 116, 105, 111, 110, 32, 61, 32, 48, 41, 32, 32, 111, 117, 116, 32, 118, 101, 99, 52, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 
13, 10, 105, 110, 32, 118, 101, 99, 50, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 102, 108, 111, 97, 116, 32, 109, 101, 100, 105, 97, 110, 95, 105, 100, 51, 40, 102, 108, 111, 97, 116, 32, 114, 44, 32, 102, 108, 111, 97, 116, 32, 103, 44, 32, 102, 108, 111, 97, 116, 
32, 98, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 109, 97, 120, 40, 109, 105, 110, 40, 114, 44, 32, 103, 41, 44, 32, 109, 105, 110, 40, 109, 97, 120, 40, 114, 44, 32, 103, 41, 44, 32, 98, 41, 41, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 70, 
111, 110, 116, 67, 111, 108, 111, 114, 95, 105, 100, 52, 40, 118, 101, 99, 52, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 32, 98, 111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 
44, 32, 102, 108, 111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 32, 61, 32, 99, 108, 97, 109, 112, 40, 98, 111, 114, 100, 101, 114, 84, 
104, 105, 99, 107, 110, 101, 115, 115, 44, 32, 102, 108, 111, 97, 116, 40, 48, 41, 44, 32, 48, 46, 50, 41, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 115, 104, 97, 114, 112, 110, 101, 115, 115, 77, 97, 103, 110, 105, 116, 117, 100, 101, 32, 61, 32, 48, 46, 53, 102, 59, 13, 
10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 97, 120, 105, 115, 68, 105, 115, 116, 97, 110, 99, 101, 32, 61, 32, 48, 46, 52, 32, 45, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 109, 101, 100, 105, 
97, 110, 68, 105, 115, 116, 97, 110, 99, 101, 32, 61, 32, 109, 101, 100, 105, 97, 110, 95, 105, 100, 51, 40, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 46, 114, 44, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 46, 103, 44, 32, 115, 97, 109, 112, 108, 101, 100, 67, 
111, 108, 111, 114, 46, 98, 41, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 115, 105, 103, 68, 105, 115, 116, 32, 61, 32, 109, 101, 100, 105, 97, 110, 68, 105, 115, 116, 97, 110, 99, 101, 32, 45, 32, 97, 120, 105, 115, 68, 105, 115, 116, 97, 110, 99, 101, 59, 13, 10, 32, 32, 
32, 32, 102, 108, 111, 97, 116, 32, 116, 114, 97, 110, 115, 105, 116, 105, 111, 110, 32, 61, 32, 102, 119, 105, 100, 116, 104, 40, 115, 105, 103, 68, 105, 115, 116, 41, 32, 42, 32, 48, 46, 56, 53, 59, 13, 10, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 111, 112, 97, 99, 105, 116, 121, 32, 
61, 32, 115, 109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 45, 116, 114, 97, 110, 115, 105, 116, 105, 111, 110, 44, 32, 116, 114, 97, 110, 115, 105, 116, 105, 111, 110, 44, 32, 115, 105, 103, 68, 105, 115, 116, 41, 59, 13, 10, 32, 32, 32, 32, 111, 112, 97, 99, 105, 116, 121, 32, 42, 61, 32, 
111, 112, 97, 99, 105, 116, 121, 59, 13, 10, 32, 32, 32, 32, 105, 102, 32, 40, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 32, 62, 32, 102, 108, 111, 97, 116, 40, 48, 41, 41, 13, 10, 32, 32, 32, 32, 123, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 
111, 97, 116, 32, 102, 97, 114, 68, 105, 115, 116, 97, 110, 99, 101, 32, 61, 32, 97, 120, 105, 115, 68, 105, 115, 116, 97, 110, 99, 101, 32, 43, 32, 98, 111, 114, 100, 101, 114, 84, 104, 105, 99, 107, 110, 101, 115, 115, 32, 42, 32, 102, 108, 111, 97, 116, 40, 50, 41, 59, 13, 10, 32, 32, 
32, 32, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 115, 105, 103, 68, 105, 115, 116, 66, 111, 114, 100, 101, 114, 32, 61, 32, 109, 101, 100, 105, 97, 110, 68, 105, 115, 116, 97, 110, 99, 101, 32, 45, 32, 102, 97, 114, 68, 105, 115, 116, 97, 110, 99, 101, 59, 13, 10, 32, 32, 32, 32, 32, 
32, 32, 32, 102, 108, 111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 76, 105, 110, 101, 32, 61, 32, 115, 104, 97, 114, 112, 110, 101, 115, 115, 77, 97, 103, 110, 105, 116, 117, 100, 101, 32, 42, 32, 115, 105, 103, 68, 105, 115, 116, 66, 111, 114, 100, 101, 114, 32, 47, 32, 102, 119, 105, 100, 116, 
104, 40, 115, 105, 103, 68, 105, 115, 116, 66, 111, 114, 100, 101, 114, 41, 32, 43, 32, 102, 97, 114, 68, 105, 115, 116, 97, 110, 99, 101, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 102, 108, 111, 97, 116, 32, 98, 111, 114, 100, 101, 114, 79, 112, 97, 99, 105, 116, 121, 32, 61, 32, 115, 
109, 111, 111, 116, 104, 115, 116, 101, 112, 40, 102, 108, 111, 97, 116, 40, 48, 41, 44, 32, 102, 108, 111, 97, 116, 40, 49, 41, 44, 32, 98, 111, 114, 100, 101, 114, 76, 105, 110, 101, 41, 59, 13, 10, 32, 32, 32, 32, 32, 32, 32, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 32, 61, 32, 
109, 105, 120, 40, 98, 111, 114, 100, 101, 114, 67, 111, 108, 111, 114, 44, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 40, 98, 111, 114, 100, 101, 114, 79, 112, 97, 99, 105, 116, 121, 41, 41, 59, 13, 10, 32, 32, 32, 32, 125, 13, 10, 32, 32, 32, 32, 115, 97, 
109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 32, 61, 32, 109, 105, 120, 40, 118, 101, 99, 52, 40, 48, 44, 32, 48, 44, 32, 48, 44, 32, 48, 41, 44, 32, 116, 101, 120, 116, 67, 111, 108, 111, 114, 44, 32, 118, 101, 99, 52, 40, 111, 112, 97, 99, 105, 116, 121, 41, 41, 59, 13, 10, 32, 
32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 115, 97, 109, 112, 108, 101, 100, 67, 111, 108, 111, 114, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 
114, 101, 97, 109, 115, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 116, 101, 120, 116, 117, 114, 101, 40, 84, 101, 120, 116, 117, 114, 101, 48, 95, 105, 100, 49, 51, 95, 83, 97, 109, 112, 108, 101, 114, 95, 105, 100, 52, 49, 44, 32, 115, 116, 114, 101, 97, 109, 
115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 41, 59, 13, 10, 125, 13, 10, 118, 101, 99, 52, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 53, 40, 105, 110, 111, 117, 116, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 41, 
13, 10, 123, 13, 10, 32, 32, 32, 32, 114, 101, 116, 117, 114, 110, 32, 70, 111, 110, 116, 67, 111, 108, 111, 114, 95, 105, 100, 52, 40, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 50, 40, 115, 116, 114, 101, 97, 109, 115, 41, 44, 32, 67, 111, 108, 111, 114, 95, 105, 100, 55, 51, 44, 32, 
118, 101, 99, 52, 40, 48, 44, 32, 48, 44, 32, 48, 44, 32, 49, 41, 44, 32, 48, 46, 102, 41, 59, 13, 10, 125, 13, 10, 118, 111, 105, 100, 32, 109, 97, 105, 110, 40, 41, 13, 10, 123, 13, 10, 32, 32, 32, 32, 86, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 105, 110, 112, 117, 
116, 95, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 118, 95, 84, 69, 88, 67, 79, 79, 82, 68, 48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 
83, 104, 97, 100, 105, 110, 103, 80, 111, 115, 105, 116, 105, 111, 110, 95, 105, 100, 48, 32, 61, 32, 103, 108, 95, 70, 114, 97, 103, 67, 111, 111, 114, 100, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 83, 84, 82, 69, 65, 77, 83, 32, 115, 116, 114, 101, 97, 109, 115, 59, 13, 10, 32, 32, 
32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 32, 61, 32, 95, 48, 105, 110, 112, 117, 116, 95, 48, 46, 84, 101, 120, 67, 111, 111, 114, 100, 95, 105, 100, 54, 49, 59, 13, 10, 32, 32, 32, 32, 115, 116, 114, 101, 97, 109, 115, 46, 
67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 83, 104, 97, 100, 105, 110, 103, 95, 105, 100, 53, 40, 115, 116, 114, 101, 97, 109, 115, 41, 59, 13, 10, 32, 32, 32, 32, 80, 83, 95, 79, 85, 84, 80, 85, 84, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 
48, 59, 13, 10, 32, 32, 32, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 115, 116, 114, 101, 97, 109, 115, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 13, 10, 32, 
32, 32, 32, 111, 117, 116, 95, 103, 108, 95, 102, 114, 97, 103, 100, 97, 116, 97, 95, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 32, 61, 32, 95, 48, 111, 117, 116, 112, 117, 116, 95, 48, 46, 67, 111, 108, 111, 114, 84, 97, 114, 103, 101, 116, 95, 105, 100, 49, 59, 
13, 10, 125, 13, 10, 1, 69, 217, 79, 232, 132, 86, 62, 83, 141, 75, 71, 64, 196, 22, 200, 94, 
        };
    }
}
#endif
