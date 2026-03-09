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
/// Entity involved in an activity.
/// </summary>
[IsoId("_Pb058Np-Ed-ak6NoX_4Aeg_-1884789497")]
[DisplayName("Party Identification And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentificationAndAccount6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentificationAndAccount6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentificationAndAccount6( PartyIdentification25 reqPartyIdentification )
    {
        PartyIdentification = reqPartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an organisation, to unambiguously identify a party.
    /// </summary>
    [IsoId("_Pb058dp-Ed-ak6NoX_4Aeg_-1934636240")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification25 PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification25 PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification25 PartyIdentification { get; init; } 
    #else
    public PartyIdentification25 PartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of an account held by Financing Requestor to First Agent. This account is requested to be used for crediting the amount financed, as a result of the financing process.
    /// </summary>
    [IsoId("_Pb058tp-Ed-ak6NoX_4Aeg_1132049413")]
    [DisplayName("Credit Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtAcct")]
    #endif
    [IsoXmlTag("CdtAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? CreditAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? CreditAccount { get; init; } 
    #else
    public CashAccount7? CreditAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Unambiguous identification of an internal bank account used by First Agent to manage the line of credit granted to Financing Requestor. This account is requested to be used for managing the financing process.
    /// </summary>
    [IsoId("_Pb0589p-Ed-ak6NoX_4Aeg_1145898985")]
    [DisplayName("Financing Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgAcct")]
    #endif
    [IsoXmlTag("FincgAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount7? FinancingAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount7? FinancingAccount { get; init; } 
    #else
    public CashAccount7? FinancingAccount { get; set; } 
    #endif
    
    
    #nullable disable
    
}
