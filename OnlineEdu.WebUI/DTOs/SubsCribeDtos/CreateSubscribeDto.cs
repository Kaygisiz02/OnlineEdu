namespace OnlineEdu.WebUI.DTOs.SubsCribeDtos
{
    public class CreateSubscribeDto
    {
        public string Email { get; set; }
        private bool IsActive { get => true; }
    }
}
