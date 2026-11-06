// Copyright (c) Files Community
// Licensed under the MIT License.

using Files.Shared.Attributes;

namespace Files.Storage
{
	[RegistrySerializable]
	public sealed class FolderCustomization
	{
		public ulong? Frn { get; set; }
		public string FolderPath { get; set; } = string.Empty;
		public string? ColorHex { get; set; }
		public string? Description { get; set; }
		public string? IconPath { get; set; }
	}
}
