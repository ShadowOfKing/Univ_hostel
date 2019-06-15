using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using univ_hostel.Models.RequestWork;

namespace univ_hostel.Helpers
{
	public static class RequestHelper
	{
		private static readonly Dictionary<RequestStatus, string> _requestNames;

		static RequestHelper()
		{
			_requestNames = new Dictionary<RequestStatus, string>
			{
				{RequestStatus.InWork, "В обработке" },
				{RequestStatus.Reject, "Отклонена" },
				{RequestStatus.Succeed, "Принята" }
			};
		}

		public static string GetStatusName(RequestStatus? status) => _requestNames[status ?? RequestStatus.InWork];
		public static RequestStatus GetStatus(string name)
		{
			foreach (var p in _requestNames)
			{
				if (p.Value.ToLower() == name.ToLower())
				{
					return p.Key;
				}
			}
			throw new ArgumentException("Некорректное название статуса", nameof(name));
		}
	}
}
