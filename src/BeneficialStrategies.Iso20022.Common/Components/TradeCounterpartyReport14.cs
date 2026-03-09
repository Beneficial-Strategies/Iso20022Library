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
[IsoId("_ne8ZGXg-Eeu3kecHd7QKUQ")]
[DisplayName("Trade Counterparty Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TradeCounterpartyReport14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TradeCounterpartyReport14 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TradeCounterpartyReport14( Counterparty34 reqReportingCounterparty,Counterparty31 reqOtherCounterparty )
    {
        ReportingCounterparty = reqReportingCounterparty;
        OtherCounterparty = reqOtherCounterparty;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the counterparty to a derivative transaction who is fulfilling its reporting obligation in the present report.
    /// </summary>
    [IsoId("_ntOssXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Reporting Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RptgCtrPty")]
    #endif
    [IsoXmlTag("RptgCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Counterparty34 ReportingCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Counterparty34 ReportingCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Counterparty34 ReportingCounterparty { get; init; } 
    #else
    public Counterparty34 ReportingCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the other counterparty to a derivative transaction.
    /// </summary>
    [IsoId("_ntOss3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Other Counterparty")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrCtrPty")]
    #endif
    [IsoXmlTag("OthrCtrPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Counterparty31 OtherCounterparty { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Counterparty31 OtherCounterparty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Counterparty31 OtherCounterparty { get; init; } 
    #else
    public Counterparty31 OtherCounterparty { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the broker as an intermediary for the reporting counterparty.
    /// </summary>
    [IsoId("_ntOstXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Broker")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Brkr")]
    #endif
    [IsoXmlTag("Brkr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification10Choice_? Broker { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification10Choice_? Broker { get; init; } 
    #else
    public OrganisationIdentification10Choice_? Broker { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party that ultimately submits the report to the trade repository.
    /// </summary>
    [IsoId("_ntOst3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Submitting Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubmitgAgt")]
    #endif
    [IsoXmlTag("SubmitgAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification10Choice_? SubmittingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification10Choice_? SubmittingAgent { get; init; } 
    #else
    public OrganisationIdentification10Choice_? SubmittingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the clearing member through which a derivative transaction is cleared at a central counterparty (CCP).  The element applies to transactions under the agency clearing model and the principal clearing model.
    /// </summary>
    [IsoId("_ntOsuXg-Eeu3kecHd7QKUQ")]
    [DisplayName("Clearing Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrMmb")]
    #endif
    [IsoXmlTag("ClrMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OrganisationIdentification10Choice_? ClearingMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrganisationIdentification10Choice_? ClearingMember { get; init; } 
    #else
    public OrganisationIdentification10Choice_? ClearingMember { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the beneficiary of a derivative transaction, ie a party that is subject to the rights and obligations arising from the contract.
    /// ||Usage: The first iteration must always be the beneficiary 1 of the counterparty 1 and the second iteration is the beneficiary 2 of the counterparty 2.
    /// </summary>
    [IsoId("_ntOsu3g-Eeu3kecHd7QKUQ")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<PartyIdentification235Choice_> Beneficiary { get; init; } = new ValueList<PartyIdentification235Choice_>(){};
    
    
    #nullable disable
    
}
