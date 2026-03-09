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
    /// Choice between a standard code or a proprietary code to indicate if a corporate action event is mandatory or not.
    /// </summary>
    [KnownType(typeof(CorporateActionMandatoryVoluntary4Choice.Code))]
    [KnownType(typeof(CorporateActionMandatoryVoluntary4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary4Choice.Code),nameof(CorporateActionMandatoryVoluntary4Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary4Choice.Proprietary),nameof(CorporateActionMandatoryVoluntary4Choice.Proprietary))]
    #endif
    [IsoId("_cdRCF5KQEeWHWpTQn1FFVg")]
    [DisplayName("Corporate Action Mandatory Voluntary 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionMandatoryVoluntary4Choice_
    #else
    public abstract partial class CorporateActionMandatoryVoluntary4Choice_
    #endif
    {
    }
}
