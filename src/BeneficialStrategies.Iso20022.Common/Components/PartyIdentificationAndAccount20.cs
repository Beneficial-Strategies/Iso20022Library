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
/// Party and account details.
/// </summary>
[IsoId("_PXWpqtp-Ed-ak6NoX_4Aeg_1436936295")]
[DisplayName("Party Identification And Account")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyIdentificationAndAccount20
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyIdentificationAndAccount20 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyIdentificationAndAccount20( PartyIdentification10Choice_ reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_PXgaoNp-Ed-ak6NoX_4Aeg_1615054967")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification10Choice_ Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification10Choice_ Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification10Choice_ Identification { get; init; } 
    #else
    public PartyIdentification10Choice_ Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    [IsoId("_PXgaodp-Ed-ak6NoX_4Aeg_1323097229")]
    [DisplayName("Alternate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AltrnId")]
    #endif
    [IsoXmlTag("AltrnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AlternatePartyIdentification2? AlternateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AlternatePartyIdentification2? AlternateIdentification { get; init; } 
    #else
    public AlternatePartyIdentification2? AlternateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    [IsoId("_PXgaotp-Ed-ak6NoX_4Aeg_617982614")]
    [DisplayName("Cash Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAcct")]
    #endif
    [IsoXmlTag("CshAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification5Choice_? CashAccount { get; init; } 
    #else
    public CashAccountIdentification5Choice_? CashAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account to be used for charges/fees if different from the account for payment.
    /// </summary>
    [IsoId("_PXgao9p-Ed-ak6NoX_4Aeg_-2066556561")]
    [DisplayName("Charges Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChrgsAcct")]
    #endif
    [IsoXmlTag("ChrgsAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountIdentification5Choice_? ChargesAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification5Choice_? ChargesAccount { get; init; } 
    #else
    public CashAccountIdentification5Choice_? ChargesAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account to be used for commission if different from the account for payment.
    /// </summary>
    [IsoId("_PXgapNp-Ed-ak6NoX_4Aeg_1231338382")]
    [DisplayName("Commission Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ComssnAcct")]
    #endif
    [IsoXmlTag("ComssnAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountIdentification5Choice_? CommissionAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification5Choice_? CommissionAccount { get; init; } 
    #else
    public CashAccountIdentification5Choice_? CommissionAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Account to be used for taxes if different from the account for payment.
    /// </summary>
    [IsoId("_PXgapdp-Ed-ak6NoX_4Aeg_234266029")]
    [DisplayName("Tax Account")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxAcct")]
    #endif
    [IsoXmlTag("TaxAcct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountIdentification5Choice_? TaxAccount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountIdentification5Choice_? TaxAccount { get; init; } 
    #else
    public CashAccountIdentification5Choice_? TaxAccount { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information to a party identification.
    /// </summary>
    [IsoId("_PXgaptp-Ed-ak6NoX_4Aeg_-762806324")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyTextInformation2? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyTextInformation2? AdditionalInformation { get; init; } 
    #else
    public PartyTextInformation2? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
