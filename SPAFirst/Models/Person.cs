using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SPAFirst.Models
{
	public enum JobTitle
	{
		[Display(ResourceType =typeof(Resources.Messages),Name =Resources.Strings.MessagesKeys.AdminTitle)]
		Admin=1,
		[Display(ResourceType =typeof(Resources.Messages),Name =Resources.Strings.MessagesKeys.UserTitle)]
		User
	}

	[Table("People",Schema ="Login")]
	public class Person
	{
		public int PersonID { get; set; }

		[Required(AllowEmptyStrings =false,ErrorMessageResourceType =typeof(Resources.Messages),ErrorMessageResourceName =Resources.Strings.MessagesKeys.Required)]
		[StringLength(30,MinimumLength =3,ErrorMessageResourceType =typeof(Resources.Messages),ErrorMessageResourceName =Resources.Strings.MessagesKeys.StringLength)]
		[Display(ResourceType =typeof(Resources.Messages),Name =Resources.Strings.MessagesKeys.FirstName)]
		[Column(TypeName ="NVarchar")]
		public string FirstName { get; set; }

		[Required(AllowEmptyStrings = false, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = Resources.Strings.MessagesKeys.Required)]
		[StringLength(30, MinimumLength = 3, ErrorMessageResourceType = typeof(Resources.Messages), ErrorMessageResourceName = Resources.Strings.MessagesKeys.StringLength)]
		[Display(ResourceType = typeof(Resources.Messages), Name = Resources.Strings.MessagesKeys.LastName)]
		[Column(TypeName = "NVarchar")]
		public string LastName { get; set; }

		[Display(ResourceType =typeof(Resources.Messages),Name =Resources.Strings.MessagesKeys.Title)]
		public JobTitle Title { get; set; }

		[Display(ResourceType = typeof(Resources.Messages), Name = Resources.Strings.MessagesKeys.IsActive)]
		public bool IsActive { get; set; }
	}
}