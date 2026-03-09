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
    /// Choice of intermediary role.
    /// </summary>
    [KnownType(typeof(IntermediaryRoleChoice1.Role))]
    [KnownType(typeof(IntermediaryRoleChoice1.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(IntermediaryRoleChoice1.Role),nameof(IntermediaryRoleChoice1.Role))]
    [JsonDerivedType(typeof(IntermediaryRoleChoice1.Proprietary),nameof(IntermediaryRoleChoice1.Proprietary))]
    #endif
    [IsoId("_RhC6Btp-Ed-ak6NoX_4Aeg_991190006")]
    [DisplayName("Intermediary Role Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record IntermediaryRoleChoice1_
    #else
    public abstract partial class IntermediaryRoleChoice1_
    #endif
    {
    }
}
