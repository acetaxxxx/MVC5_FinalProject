using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.ViewModels
{
	public class LoginViewModel
	{
		[Required]
		[Display(Name ="帳號")]
		[EmailAddress]
		[Remote("verify" , "Home",ErrorMessage = "名稱錯誤，不能包含demo,skilltree,teMVC")]
		public string account { get; set; }

		[Required]
		[Display(Name ="密碼")]
		[StringLength(20,MinimumLength =4)]		
		public string password { get; set; }
	}
}