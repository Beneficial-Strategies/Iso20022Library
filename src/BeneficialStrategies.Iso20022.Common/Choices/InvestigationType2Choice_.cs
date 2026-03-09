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
    /// Specifies the type of an investigation.
    /// </summary>
    [KnownType(typeof(InvestigationType2Choice.Code))]
    [KnownType(typeof(InvestigationType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(InvestigationType2Choice.Code),nameof(InvestigationType2Choice.Code))]
    [JsonDerivedType(typeof(InvestigationType2Choice.Proprietary),nameof(InvestigationType2Choice.Proprietary))]
    #endif
    [IsoId("_yQ8IIXbkEe2GR4CRzIB77g")]
    [DisplayName("Investigation Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record InvestigationType2Choice_
    #else
    public abstract partial class InvestigationType2Choice_
    #endif
    {
    }
}
