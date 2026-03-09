// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes search criteria for securities account audit trail query.
/// </summary>
[IsoId("_0Ba1cTpzEemk2e6qGBk8IQ")]
[DisplayName("Securities Account Audit Trail Search Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAccountAuditTrailSearchCriteria3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the securities account to be queried.
    /// </summary>
    [IsoId("_0L2j0TpzEemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAcctId")]
    #endif
    [IsoXmlTag("SctiesAcctId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesAccount19? SecuritiesAccountIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesAccount19? SecuritiesAccountIdentification { get; init; } 
    #else
    public SecuritiesAccount19? SecuritiesAccountIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the period for querying information.
    /// </summary>
    [IsoId("_0L2j0zpzEemk2e6qGBk8IQ")]
    [DisplayName("Date Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtPrd")]
    #endif
    [IsoXmlTag("DtPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DatePeriodSearch1Choice_? DatePeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DatePeriodSearch1Choice_? DatePeriod { get; init; } 
    #else
    public DatePeriodSearch1Choice_? DatePeriod { get; set; } 
    #endif
    
    
    #nullable disable
    
}
