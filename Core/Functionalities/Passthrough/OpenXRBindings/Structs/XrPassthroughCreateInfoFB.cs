﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Core.Functionalities.Passthrough.PassthroughOpenXRBindings;

namespace Core.Functionalities.Passthrough.OpenXRBindings.Structs
{
    // https://registry.khronos.org/OpenXR/specs/1.0/man/html/XrPassthroughCreateInfoFB.html
    [StructLayout(LayoutKind.Sequential)]
    internal struct XrPassthroughCreateInfoFB
    {
        private readonly XrStructureType type;
        public readonly nint next;
        public readonly XrPassthroughFlagsFB flags;

        public XrPassthroughCreateInfoFB(XrPassthroughFlagsFB passthroughFlags)
        {
            type = XrStructureType.XR_TYPE_PASSTHROUGH_CREATE_INFO_FB;
            next = nint.Zero;
            flags = passthroughFlags;
        }
    }
}