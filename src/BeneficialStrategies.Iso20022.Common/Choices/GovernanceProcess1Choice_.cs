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
    /// Choice of formats for a type of governance process.
    /// </summary>
    [KnownType(typeof(GovernanceProcess1Choice.Code))]
    [KnownType(typeof(GovernanceProcess1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(GovernanceProcess1Choice.Code),nameof(GovernanceProcess1Choice.Code))]
    [JsonDerivedType(typeof(GovernanceProcess1Choice.Proprietary),nameof(GovernanceProcess1Choice.Proprietary))]
    #endif
    [IsoId("_f3PLYID4Eeiw-daIkkmMqQ")]
    [DisplayName("Governance Process 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record GovernanceProcess1Choice_
    #else
    public abstract partial class GovernanceProcess1Choice_
    #endif
    {
    }
}
