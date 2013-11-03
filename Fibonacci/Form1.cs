using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        private MethodInfo m_methodInfo = null;
        private object m_objectCompiled = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_code = new LoadAlgorithms().Load(LoadAlgorithms.c_Tail_Recursive_Url);
            Compile(m_code);
        }
        
        private string m_code = string.Empty;

        private void Compile(string code)
        {
            Dictionary<string, string> providerOptions = new Dictionary<string, string>
                {
                    {"CompilerVersion", "v3.5"}
                };
            CSharpCodeProvider provider = new CSharpCodeProvider(providerOptions);

            CompilerParameters compilerParams = new CompilerParameters
            {
                GenerateInMemory = true,
                GenerateExecutable = false
            };

            CompilerResults results = provider.CompileAssemblyFromSource(compilerParams, code);

            if (results.Errors.Count != 0)
                throw new Exception("Mission failed!");

            object o = results.CompiledAssembly.CreateInstance("Fibonacci");
            MethodInfo mi = o.GetType().GetMethod("Fib");

            m_methodInfo = mi;
            m_objectCompiled = o;    
        }
        
        private string CheckOK()
        {
            if(string.IsNullOrEmpty(textBoxNumber.Text) == true)
            {
                return ErrorMessages.NUMBEREMPTY;
            }

            foreach (char c in textBoxNumber.Text.ToCharArray())
            {
                if (Char.IsLetter(c) == true)
                {
                    return ErrorMessages.NONUMBER;
                }
            }
            
            return string.Empty;
        }
                
        private void buttonShowCode_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = m_code;
        }

        private void buttonDo_Click(object sender, EventArgs e)
        {
            string message = CheckOK();

            if (string.IsNullOrEmpty(message) == true)
            {
                if (m_methodInfo != null)
                {
                    object a = m_methodInfo.Invoke(m_objectCompiled, new object[] { uint.Parse(textBoxNumber.Text) });

                    textBoxResult.Text = a.ToString();
                }
                else
                {
                    MessageBox.Show("No se ha realizado la carga del algoritmo correctamente");
                }
            }
            else
            {
                MessageBox.Show(message);
            }
        }


    
    }
}
