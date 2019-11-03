using System;
using System.Collections.Generic;
using System.Text;

namespace CSAc4y.Class
{
	public class Ac4yIdentificationAlgebra : Ac4yIdentificationPreProcessed
	{

		public Ac4yIdentificationBase getTemplate() {
        		return template;
        }

		public Int32 getId() {
        		return id;
        }

		public String getGUID() {
        		return GUID;
        }

		public String getHumanId() {
        		return HumanId;
        }

		public String getPublicHumanId() {
        		return PublicHumanId;
        }

		public DateTime getCreatedAt() {
        		return CreatedAt;
        }

		public String getUpdatedAt() {
        		return UpdatedAt;
        }


    		public void setTemplate(Ac4yIdentificationBase newValue) {
        		template = newValue;
        }

    		public void setId(Int32 newValue) {
        		id = newValue;
        }

    		public void setGUID(String newValue) {
        		GUID = newValue;
        }

    		public void setHumanId(String newValue) {
        		HumanId = newValue;
        }

    		public void setPublicHumanId(String newValue) {
        		PublicHumanId = newValue;
        }

    		public void setCreatedAt(DateTime newValue) {
        		CreatedAt = newValue;
        }

    		public void setUpdatedAt(String newValue) {
        		UpdatedAt = newValue;
        }
	
		public Boolean hasTemplate(){
			if(this.getTemplate() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasId(){
			if(this.getId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasGUID(){
			if(this.getGUID() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasHumanId(){
			if(this.getHumanId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasPublicHumanId(){
			if(this.getPublicHumanId() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasCreatedAt(){
			if(this.getCreatedAt() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

		public Boolean hasUpdatedAt(){
			if(this.getUpdatedAt() != null){

				return true;
			}
			else
			{
				return false;
			}
		}

    


	}
}
