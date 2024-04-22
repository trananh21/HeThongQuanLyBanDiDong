using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace He_Thong_quan_ly_di_dong_dien_thoai.Presenter.Common
{
    public class ModelDataValidation
    {
        public void Validate(object model)
        {
            string errorMesssage = " ";
            List<ValidationResult> results = new List<ValidationResult> ();
            ValidationContext context = new ValidationContext (model);

            bool isValid = Validator.TryValidateObject(model, context, results, true);
            if(isValid == false) 
            {
                foreach(var item in results)
                {   
                    errorMesssage += "- " + item.ErrorMessage + "\n";
                }

                throw new Exception (errorMesssage);
            }
        }
    }
}
