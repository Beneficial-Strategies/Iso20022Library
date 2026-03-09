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
/// Information identifying the disclosure request for shareholders identification published by the issuer or third party nominated by the issuer in order to receive the disclosure responses from intermediaries in the custody chain.
/// </summary>
[IsoId("_im8pMDqgEemL_ewJY9QP1g")]
[DisplayName("Disclosure Request Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DisclosureRequestIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DisclosureRequestIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DisclosureRequestIdentification1( System.String reqIssuerDisclosureRequestIdentification,SecurityIdentification19 reqFinancialInstrumentIdentification,DateFormat46Choice_ reqShareholdersDisclosureRecordDate )
    {
        IssuerDisclosureRequestIdentification = reqIssuerDisclosureRequestIdentification;
        FinancialInstrumentIdentification = reqFinancialInstrumentIdentification;
        ShareholdersDisclosureRecordDate = reqShareholdersDisclosureRecordDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Official and unique reference assigned to a shareholders identification disclosure request process by the issuer or third party nominated by him.
    /// </summary>
    [IsoId("_O-niQzqhEemL_ewJY9QP1g")]
    [DisplayName("Issuer Disclosure Request Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrDsclsrReqId")]
    #endif
    [IsoXmlTag("IssrDsclsrReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text IssuerDisclosureRequestIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IssuerDisclosureRequestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IssuerDisclosureRequestIdentification { get; init; } 
    #else
    public System.String IssuerDisclosureRequestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the financial instrument.
    /// </summary>
    [IsoId("_O-niRDqhEemL_ewJY9QP1g")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification19 FinancialInstrumentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date set by the issuer on which shareholders identity is determined based on the settled positions struck in the books of the Issuer CSD or any other first intermediary at the close of business day. 
    /// </summary>
    [IsoId("_O-niRTqhEemL_ewJY9QP1g")]
    [DisplayName("Shareholders Disclosure Record Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrhldrsDsclsrRcrdDt")]
    #endif
    [IsoXmlTag("ShrhldrsDsclsrRcrdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; init; } 
    #else
    public DateFormat46Choice_ ShareholdersDisclosureRecordDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
