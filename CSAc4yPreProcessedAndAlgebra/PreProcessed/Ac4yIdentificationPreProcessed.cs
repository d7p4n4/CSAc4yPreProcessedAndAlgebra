
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GuidLibrary;

namespace CSAc4y.Class 
{
	            [GUID("192b6e0b-e69e-4a21-a3be-c1f0694183bf")]
	public class Ac4yIdentificationPreProcessed : Ac4yIdentificationBasePreProcessed

	{
    		public Ac4yIdentificationBase template { get; set; }
    		public Int32 id { get; set; }
    		public String GUID { get; set; }
    		public String HumanId { get; set; }
    		public String PublicHumanId { get; set; }
    		public DateTime CreatedAt { get; set; }
    		public String UpdatedAt { get; set; }
		
		public Ac4yIdentificationPreProcessed()
		{
			GUID = "192b6e0b-e69e-4a21-a3be-c1f0694183bf";
		}
	}
}