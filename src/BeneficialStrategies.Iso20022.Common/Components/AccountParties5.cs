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
/// Any party who is related to an investment account.
/// </summary>
[IsoId("_RSb2Sdp-Ed-ak6NoX_4Aeg_-1122306786")]
[DisplayName("Account Parties")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountParties5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountParties5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountParties5( InvestmentAccountOwnershipInformation5 reqPrimaryOwner,InvestmentAccountOwnershipInformation5 reqCustodianForMinor,InvestmentAccountOwnershipInformation5 reqNominee )
    {
        PrimaryOwner = reqPrimaryOwner;
        CustodianForMinor = reqCustodianForMinor;
        Nominee = reqNominee;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Single owner of the investment account or, when the ownership is split among several owners, the primary owner is the one giving its address and account details for the registration.
    /// </summary>
    [IsoId("_RSb2Stp-Ed-ak6NoX_4Aeg_-1120460595")]
    [DisplayName("Primary Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryOwnr")]
    #endif
    [IsoXmlTag("PmryOwnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccountOwnershipInformation5 PrimaryOwner { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccountOwnershipInformation5 PrimaryOwner { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation5 PrimaryOwner { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation5 PrimaryOwner { get; set; } 
    #endif
    
    /// <summary>
    /// Legal owners of the property. However, the beneficiary has the equitable or beneficial ownership.
    /// </summary>
    [IsoId("_RSb2S9p-Ed-ak6NoX_4Aeg_-1120460019")]
    [DisplayName("Trustee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Trstee")]
    #endif
    [IsoXmlTag("Trstee")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> Trustee { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Entity that holds shares/units on behalf of a legal minor. Although the account is registered under the name of the minor, the custodian retains control of the account.
    /// </summary>
    [IsoId("_RSb2TNp-Ed-ak6NoX_4Aeg_-1120459200")]
    [DisplayName("Custodian For Minor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtdnForMnr")]
    #endif
    [IsoXmlTag("CtdnForMnr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccountOwnershipInformation5 CustodianForMinor { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccountOwnershipInformation5 CustodianForMinor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation5 CustodianForMinor { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation5 CustodianForMinor { get; set; } 
    #endif
    
    /// <summary>
    /// Entity named by the beneficial owner to act on its behalf, often to facilitate dealing, or to conceal the identity of the beneficiary.
    /// </summary>
    [IsoId("_RSlnQNp-Ed-ak6NoX_4Aeg_-1120459063")]
    [DisplayName("Nominee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nmnee")]
    #endif
    [IsoXmlTag("Nmnee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestmentAccountOwnershipInformation5 Nominee { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestmentAccountOwnershipInformation5 Nominee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation5 Nominee { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation5 Nominee { get; set; } 
    #endif
    
    /// <summary>
    /// Co-owner of the investment account when the ownership is assigned to more than one party.
    /// </summary>
    [IsoId("_RSlnQdp-Ed-ak6NoX_4Aeg_-1121381248")]
    [DisplayName("Joint Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="JntOwnr")]
    #endif
    [IsoXmlTag("JntOwnr")]
    [MinLength(1)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> JointOwner { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Entity that is not the primary owner when the ownership of the investment account is split among several owners.
    /// </summary>
    [IsoId("_RSlnQtp-Ed-ak6NoX_4Aeg_-1120458211")]
    [DisplayName("Secondary Owner")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ScndryOwnr")]
    #endif
    [IsoXmlTag("ScndryOwnr")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentAccountOwnershipInformation5> SecondaryOwner { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Ultimate party that is entitled to either receive the benefits of the ownership of a financial instrument, or to be paid/credited as a result of a transfer.
    /// </summary>
    [IsoId("_RSlnQ9p-Ed-ak6NoX_4Aeg_-1119537652")]
    [DisplayName("Beneficiary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bnfcry")]
    #endif
    [IsoXmlTag("Bnfcry")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<InvestmentAccountOwnershipInformation5> Beneficiary { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Entity that was given the authority by another entity to act on its behalf.
    /// </summary>
    [IsoId("_RSlnRNp-Ed-ak6NoX_4Aeg_-1119536566")]
    [DisplayName("Power Of Attorney")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PwrOfAttny")]
    #endif
    [IsoXmlTag("PwrOfAttny")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> PowerOfAttorney { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Entity that has been appointed by a legal authority to act on behalf of a person judged to be incapacitated.
    /// </summary>
    [IsoId("_RSlnRdp-Ed-ak6NoX_4Aeg_-1119535739")]
    [DisplayName("Legal Guardian")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglGuardn")]
    #endif
    [IsoXmlTag("LglGuardn")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> LegalGuardian { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Deceased&apos;s estate, or successor, to whom the respective percentage of ownership will be transferred upon the death of one of the owners.
    /// </summary>
    [IsoId("_RSlnRtp-Ed-ak6NoX_4Aeg_-1119535566")]
    [DisplayName("Successor On Death")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SucssrOnDth")]
    #endif
    [IsoXmlTag("SucssrOnDth")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> SuccessorOnDeath { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Entity that has been appointed by a legal authorithy to act on behalf of a person or organisation that has gone bankrupt.
    /// </summary>
    [IsoId("_RSlnR9p-Ed-ak6NoX_4Aeg_-1121382569")]
    [DisplayName("Administrator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Admstr")]
    #endif
    [IsoXmlTag("Admstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestmentAccountOwnershipInformation5? Administrator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestmentAccountOwnershipInformation5? Administrator { get; init; } 
    #else
    public InvestmentAccountOwnershipInformation5? Administrator { get; set; } 
    #endif
    
    /// <summary>
    /// Other type of party.
    /// </summary>
    [IsoId("_RSlnSNp-Ed-ak6NoX_4Aeg_1473925855")]
    [DisplayName("Other Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrPty")]
    #endif
    [IsoXmlTag("OthrPty")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<ExtendedParty2> OtherParty { get; init; } = new ValueList<ExtendedParty2>(){};
    
    /// <summary>
    /// Granter role in the hedge funds industry.
    /// </summary>
    [IsoId("_RSlnSdp-Ed-ak6NoX_4Aeg_1444245145")]
    [DisplayName("Granter")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Grntr")]
    #endif
    [IsoXmlTag("Grntr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> Granter { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    /// <summary>
    /// Settler role in the hedge funds industry.
    /// </summary>
    [IsoId("_RSvYQNp-Ed-ak6NoX_4Aeg_1605862687")]
    [DisplayName("Settler")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sttlr")]
    #endif
    [IsoXmlTag("Sttlr")]
    [MinLength(0)]
    [MaxLength(5)]
    public ValueList<InvestmentAccountOwnershipInformation5> Settler { get; init; } = new ValueList<InvestmentAccountOwnershipInformation5>(){};
    
    
    #nullable disable
    
}
