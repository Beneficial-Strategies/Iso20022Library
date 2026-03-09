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
    /// Choice of processing change command status.
    /// </summary>
    [KnownType(typeof(SettlementConditionModificationStatus1Choice.Code))]
    [KnownType(typeof(SettlementConditionModificationStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementConditionModificationStatus1Choice.Code),nameof(SettlementConditionModificationStatus1Choice.Code))]
    [JsonDerivedType(typeof(SettlementConditionModificationStatus1Choice.Proprietary),nameof(SettlementConditionModificationStatus1Choice.Proprietary))]
    #endif
    [IsoId("_UYeaItp-Ed-ak6NoX_4Aeg_-936948787")]
    [DisplayName("Settlement Condition Modification Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementConditionModificationStatus1Choice_
    #else
    public abstract partial class SettlementConditionModificationStatus1Choice_
    #endif
    {
    }
}
