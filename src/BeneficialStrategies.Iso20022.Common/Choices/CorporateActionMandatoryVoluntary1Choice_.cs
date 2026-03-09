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
    [KnownType(typeof(CorporateActionMandatoryVoluntary1Choice.Code))]
    [KnownType(typeof(CorporateActionMandatoryVoluntary1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary1Choice.Code),nameof(CorporateActionMandatoryVoluntary1Choice.Code))]
    [JsonDerivedType(typeof(CorporateActionMandatoryVoluntary1Choice.Proprietary),nameof(CorporateActionMandatoryVoluntary1Choice.Proprietary))]
    #endif
    [IsoId("_Q4XJZ9p-Ed-ak6NoX_4Aeg_557244388")]
    [DisplayName("Corporate Action Mandatory Voluntary 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CorporateActionMandatoryVoluntary1Choice_
    #else
    public abstract partial class CorporateActionMandatoryVoluntary1Choice_
    #endif
    {
    }
}
