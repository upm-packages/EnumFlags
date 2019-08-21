using System;
using UnityEngine;

namespace EnumFlags
{
    [AttributeUsage(AttributeTargets.Enum | AttributeTargets.Field)]
    public sealed class EnumFlagsAttribute : PropertyAttribute
    {
    }
}