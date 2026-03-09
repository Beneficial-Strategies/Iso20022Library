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
/// Provides additional information regarding optional dividend election details.
/// </summary>
[IsoId("_zQRzsb5YEeexmbB7KsjCwA")]
[DisplayName("Optional Dividend Account Quantity SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record OptionalDividendAccountQuantitySD3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a OptionalDividendAccountQuantitySD3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public OptionalDividendAccountQuantitySD3( FinancialInstrumentQuantity15Choice_ reqBeneficialOwnerQuantity,System.String reqNumberOfAccounts )
    {
        BeneficialOwnerQuantity = reqBeneficialOwnerQuantity;
        NumberOfAccounts = reqNumberOfAccounts;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_zgpK8b5YEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Beneficial owner quantity to be paid.
    /// </summary>
    [IsoId("_zgpK875YEeexmbB7KsjCwA")]
    [DisplayName("Beneficial Owner Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BnfclOwnrQty")]
    #endif
    [IsoXmlTag("BnfclOwnrQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ BeneficialOwnerQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity15Choice_ BeneficialOwnerQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ BeneficialOwnerQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ BeneficialOwnerQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Number of accounts for which the beneficial quantity is elected.
    /// </summary>
    [IsoId("_zgpK-75YEeexmbB7KsjCwA")]
    [DisplayName("Number Of Accounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NbOfAccts")]
    #endif
    [IsoXmlTag("NbOfAccts")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax15NumericText NumberOfAccounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String NumberOfAccounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String NumberOfAccounts { get; init; } 
    #else
    public System.String NumberOfAccounts { get; set; } 
    #endif
    
    
    #nullable disable
    
}
