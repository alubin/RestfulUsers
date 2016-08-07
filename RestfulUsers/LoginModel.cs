using System;
namespace RestfulUsers
{

	/**
	 * This class represents a login object that will contain the information for logging in. 
	 * 
	 **/
	public class LoginModel
	{
		private String email = "";
		private String password = "";

		public LoginModel()
		{
		}

		public LoginModel(String email, String password)
		{
			this.email = email;
			this.password = password;
		}

		public void setEmail(String email)
		{
			this.email = email;
		}

		public void setPassword(String password)
		{
			this.password = password;
		}

		public String getEmail()
		{
			return email;
		}

		public String getPassword()
		{
			return password;
		}
	}
}

