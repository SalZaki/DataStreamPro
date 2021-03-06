﻿using MediatR;

using DataStreamPro.Producer.Spotify.Application.Models;

namespace DataStreamPro.Producer.Spotify.Application.Queries
{
    public class GetPlaylistRequest : IRequest<GetPlaylistsResponse>
    {
        public string Id { get; set; }
    }
}