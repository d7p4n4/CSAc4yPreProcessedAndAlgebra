
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GuidLibrary;

namespace CSAc4y.Class 
{
	            [GUID("a49e48b1-aab5-493d-9629-9581feb51904")]
	public class Ac4yIdentificationBasePreProcessed

	{
    		public Int32 id { get; set; }
    		public String GUID { get; set; }
    		public String HumanId { get; set; }
    		public String PublicHumanId { get; set; }
    		public DateTime CreatedAt { get; set; }
    		public String UpdatedAt { get; set; }
		
		public Ac4yIdentificationBasePreProcessed()
		{
			GUID = "a49e48b1-aab5-493d-9629-9581feb51904";
		}
	}
}