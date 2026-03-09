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
    /// Choice of quorum quantity.
    /// </summary>
    [KnownType(typeof(QuorumQuantity1Choice.QuorumQuantity))]
    [KnownType(typeof(QuorumQuantity1Choice.QuorumQuantityPercentage))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(QuorumQuantity1Choice.QuorumQuantity),nameof(QuorumQuantity1Choice.QuorumQuantity))]
    [JsonDerivedType(typeof(QuorumQuantity1Choice.QuorumQuantityPercentage),nameof(QuorumQuantity1Choice.QuorumQuantityPercentage))]
    #endif
    [IsoId("_RDiepdp-Ed-ak6NoX_4Aeg_1841562834")]
    [DisplayName("Quorum Quantity 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record QuorumQuantity1Choice_
    #else
    public abstract partial class QuorumQuantity1Choice_
    #endif
    {
    }
}
