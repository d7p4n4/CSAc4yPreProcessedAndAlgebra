
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GuidLibrary;

namespace CSAc4y.Class 
{
	            [GUID("f819ec82-d341-4b60-a1f5-6f1e407e1085")]
	public class Ac4yPersistentPreProcessed : Ac4yPreProcessed

	{
    		public Ac4yIdentification Ac4yIdentification { get; set; }
    		public Int32 id { get; set; }
		
		public Ac4yPersistentPreProcessed()
		{
			GUID = "f819ec82-d341-4b60-a1f5-6f1e407e1085";
		}
	}
}