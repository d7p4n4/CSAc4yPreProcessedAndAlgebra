
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GuidLibrary;

namespace CSAc4y.Class 
{
	            [GUID("c0dce9a0-b4c8-4d2b-9a2b-6906e1a5f434")]
	public class Ac4yPreProcessed : Ac4yObjectPreProcessed

	{
    		public Ac4yIdentification Ac4yIdentification { get; set; }
    		public Int32 id { get; set; }
		
		public Ac4yPreProcessed()
		{
			GUID = "c0dce9a0-b4c8-4d2b-9a2b-6906e1a5f434";
		}
	}
}