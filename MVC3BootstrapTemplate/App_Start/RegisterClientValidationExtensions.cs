using DataAnnotationsExtensions.ClientValidation;

[assembly: WebActivator.PreApplicationStartMethod(typeof(MVC3BootstrapTemplate.App_Start.RegisterClientValidationExtensions), "Start")]
 
namespace MVC3BootstrapTemplate.App_Start {
    public static class RegisterClientValidationExtensions {
        public static void Start() {
            DataAnnotationsModelValidatorProviderExtensions.RegisterValidationExtensions();            
        }
    }
}