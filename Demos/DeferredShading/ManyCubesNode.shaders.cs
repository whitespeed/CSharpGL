﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CSharpGL;

namespace DeferredShading
{
    partial class ManyCubesNode
    {
        private const string firstPassVert = @"#version 330 core

in vec3 vPosition;
in vec3 vColor;

uniform mat4 MVP;

out vec3 passColor;

void main()
{
	gl_Position = MVP * vec4(vPosition, 1);
    passColor = vColor;
}
";
        private const string firstPassFrag = @"#version 330 core

in vec3 passColor;

layout (location = 0) out vec3 vFragColor;

void main()
{
    vFragColor = passColor;
}
";

    }
}
