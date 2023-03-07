using Employment.Models;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Employment.Interface
{
    [Headers("User-Agent: :request:")]
    interface IGitHubApi
    {
        [Get("/messages/room_id/1?fields=room_name&limit=1")]
        Task<ApiResponse> GetUser();
    }
}
