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
/// Report information about securities reference data.
/// </summary>
[IsoId("_Ptf-NZJKEeuAlLVx8pyt3w")]
[DisplayName("Securities Audit Trail Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesAuditTrailReport4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesAuditTrailReport4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesAuditTrailReport4( AuditTrailOrBusinessError6Choice_ reqSecuritiesAuditTrailOrError,SecurityIdentification39 reqFinancialInstrumentIdentification )
    {
        SecuritiesAuditTrailOrError = reqSecuritiesAuditTrailOrError;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the returned securities reference data or error information.
    /// </summary>
    [IsoId("_PvjzsZJKEeuAlLVx8pyt3w")]
    [DisplayName("Securities Audit Trail Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesAudtTrlOrErr")]
    #endif
    [IsoXmlTag("SctiesAudtTrlOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuditTrailOrBusinessError6Choice_ SecuritiesAuditTrailOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuditTrailOrBusinessError6Choice_ SecuritiesAuditTrailOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuditTrailOrBusinessError6Choice_ SecuritiesAuditTrailOrError { get; init; } 
    #else
    public AuditTrailOrBusinessError6Choice_ SecuritiesAuditTrailOrError { get; set; } 
    #endif
    
    /// <summary>
    /// Period in dates for which the audit trail is provided.
    /// </summary>
    [IsoId("_Pvjzs5JKEeuAlLVx8pyt3w")]
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
    
    /// <summary>
    /// Identifies the securities for which the audit trail is provided.
    /// </summary>
    [IsoId("_PvjztZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification39 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification39 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
