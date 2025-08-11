// Copyright (c) 2022 bradson
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v.2.0.If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Runtime.CompilerServices;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace FisheryLib;

public static class SpanCompat
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ref T DangerousGetPinnableReference<T>(this ReadOnlySpan<T> span) => ref MemoryMarshal.GetReference(span);

	public static ref T DangerousGetPinnableReference<T>(this Span<T> span) => ref MemoryMarshal.GetReference(span);
}
