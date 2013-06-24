using System.Configuration;

namespace T4StrongAppSettings
{
	public class AppSettings
	{
		public string FirstName { get { return ConfigurationManager.AppSettings["FirstName"]; } }
		public string LastName { get { return ConfigurationManager.AppSettings["LastName"]; } }
		public string Birth { get { return ConfigurationManager.AppSettings["Birth"]; } }
	}
}