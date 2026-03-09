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
    /// Reference to the linked transaction.
    /// </summary>
    [KnownType(typeof(References70Choice.ClientCollateralInstructionIdentification))]
    [KnownType(typeof(References70Choice.TripartyAgentServiceProviderCollateralInstructionIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(References70Choice.ClientCollateralInstructionIdentification),nameof(References70Choice.ClientCollateralInstructionIdentification))]
    [JsonDerivedType(typeof(References70Choice.TripartyAgentServiceProviderCollateralInstructionIdentification),nameof(References70Choice.TripartyAgentServiceProviderCollateralInstructionIdentification))]
    #endif
    [IsoId("_21pbMFSLEemTt7251YwCKw")]
    [DisplayName("References 70 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record References70Choice_
    #else
    public abstract partial class References70Choice_
    #endif
    {
    }
}
