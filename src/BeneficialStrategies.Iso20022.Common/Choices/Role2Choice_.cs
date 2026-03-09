// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for a party role.
    /// </summary>
    [KnownType(typeof(Role2Choice.Code))]
    [KnownType(typeof(Role2Choice.Proprietary))]
    [KnownType(typeof(Role2Choice.Text))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Role2Choice.Code),nameof(Role2Choice.Code))]
    [JsonDerivedType(typeof(Role2Choice.Proprietary),nameof(Role2Choice.Proprietary))]
    [JsonDerivedType(typeof(Role2Choice.Text),nameof(Role2Choice.Text))]
    #endif
    [IsoId("_Qwm7k9p-Ed-ak6NoX_4Aeg_-1001393826")]
    [DisplayName("Role 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Role2Choice_
    #else
    public abstract partial class Role2Choice_
    #endif
    {
    }
}
