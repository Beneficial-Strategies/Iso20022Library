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
/// Information related to parties in the contract.
/// </summary>
[IsoId("_t1vHAZQGEeiILOjNP8ro1w")]
[DisplayName("Trade Counterparty Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeCounterpartyReport9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeCounterpartyReport9 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeCounterpartyReport9( Counterparty26 reqReportingCounterparty,Counterparty29 reqOtherCounterparty )
    {
        ReportingCounterparty = reqReportingCounterparty;
        OtherCounterparty = reqOtherCounterparty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the reporting counterparty.
    /// </summary>
    [IsoId("_uBkjkZQGEeiILOjNP8ro1w")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Counterparty26 ReportingCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Counterparty26 ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Counterparty26 ReportingCounterparty { get; init; } 
    #else
    public Counterparty26 ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the other counterparty in the transaction.
    /// </summary>
    [IsoId("_uBkjk5QGEeiILOjNP8ro1w")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Counterparty29 OtherCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Counterparty29 OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Counterparty29 OtherCounterparty { get; init; } 
    #else
    public Counterparty29 OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the broker as an intermediary for the reporting counterparty.
    /// </summary>
    [IsoId("_uBkjlZQGEeiILOjNP8ro1w")]
    [DisplayName("Broker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brkr")]
    #endif
    [IsoXmlTag("Brkr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification9Choice_? Broker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_? Broker { get; init; } 
    #else
    public OrganisationIdentification9Choice_? Broker { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the submitting agent in the case where the reporting counterparty has delegated the submission of the report to a third party or to the other counterparty.
    /// </summary>
    [IsoId("_uBkjl5QGEeiILOjNP8ro1w")]
    [DisplayName("Submitting Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitgAgt")]
    #endif
    [IsoXmlTag("SubmitgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification9Choice_? SubmittingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_? SubmittingAgent { get; init; } 
    #else
    public OrganisationIdentification9Choice_? SubmittingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the clearing member in the case where the trade is cleared.
    /// </summary>
    [IsoId("_uBkjmZQGEeiILOjNP8ro1w")]
    [DisplayName("Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmb")]
    #endif
    [IsoXmlTag("ClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification9Choice_? ClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_? ClearingMember { get; init; } 
    #else
    public OrganisationIdentification9Choice_? ClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the beneficiary who is subject to the rights and obligations arising from the contract.
    /// </summary>
    [IsoId("_uBkjm5QGEeiILOjNP8ro1w")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification9Choice_? Beneficiary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification9Choice_? Beneficiary { get; init; } 
    #else
    public OrganisationIdentification9Choice_? Beneficiary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
