// Copyright (c) 2022 bradson
// This Source Code Form is subject to the terms of the Mozilla Public
// License, v.2.0.If a copy of the MPL was not distributed with this
// file, You can obtain one at https://mozilla.org/MPL/2.0/.

using System.Runtime.CompilerServices;


namespace FisheryLib;
#if V1_6
public static class SpanCompat
{

	// Unsafe.AsRef(T) reinterprets the given read-only reference as a mutable reference.
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ref T DangerousGetPinnableReference<T>(this ReadOnlySpan<T> span) => ref Unsafe.AsRef(span.GetPinnableReference());

	public static ref T DangerousGetPinnableReference<T>(this Span<T> span) => ref span.GetPinnableReference();
}
#endif