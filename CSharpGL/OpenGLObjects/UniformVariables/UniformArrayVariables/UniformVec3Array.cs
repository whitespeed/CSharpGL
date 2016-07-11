﻿
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;


namespace CSharpGL
{
    /// <summary>
    /// uniform vec3 variable[10];
    /// </summary>
    public class UniformVec3Array : UniformArrayVariable
    {

        private vec3[] value;

        /// <summary>
        /// 
        /// </summary>
        public vec3[] Value
        {
            get { return this.value; }
            set
            {
                if (this.value != value)
                {
                    this.value = value;
                    this.Updated = true;
                }
            }
        }

        /// <summary>
        /// uniform vec3 variable[10];
        /// </summary>
        /// <param name="varName"></param>
        public UniformVec3Array(string varName) : base(varName) { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="program"></param>
        public override void SetUniform(ShaderProgram program)
        {
            this.Location = program.SetUniform(VarName, value);
        }

        protected override Array GetValue()
        {
            return this.value;
        }
    }

}
