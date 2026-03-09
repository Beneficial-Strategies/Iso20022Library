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
    /// Choice of format for the governance rules.
    /// </summary>
    [KnownType(typeof(GovernanceIdentification1Choice.Code))]
    [KnownType(typeof(GovernanceIdentification1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GovernanceIdentification1Choice.Code),nameof(GovernanceIdentification1Choice.Code))]
    [JsonDerivedType(typeof(GovernanceIdentification1Choice.Proprietary),nameof(GovernanceIdentification1Choice.Proprietary))]
    #endif
    [IsoId("_929T0HltEeG7BsjMvd1mEw_-112960495")]
    [DisplayName("Governance Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GovernanceIdentification1Choice_
    #else
    public abstract partial class GovernanceIdentification1Choice_
    #endif
    {
    }
}
