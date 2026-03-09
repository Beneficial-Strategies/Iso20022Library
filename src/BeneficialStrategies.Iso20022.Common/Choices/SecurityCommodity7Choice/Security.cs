// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.SecurityCommodity7Choice
{
    /// <summary>
    /// Data specific to securities being subject to the transaction.
    /// </summary>
    [IsoId("_Ul6y8cgyEeuGrNSsxk3B0A")]
    [DisplayName("Security")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Security : SecurityCommodity7Choice_
    #else
    public partial class Security : SecurityCommodity7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies whether the values defined as ISIN (International Securities Identification Number-ISO 6166) identifier are matching or not.
        /// </summary>
        [IsoId("_A4HkI8K3EeuFNp8LZAnorg")]
        [DisplayName("Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Id")]
        #endif
        [IsoXmlTag("Id")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareISINIdentifier4? Identification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareISINIdentifier4? Identification { get; init; } 
        #else
        public CompareISINIdentifier4? Identification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as CFI (Classification of Financial Instruments-ISO 10962) identifier are matching or not.
        /// </summary>
        [IsoId("_A4HkJcK3EeuFNp8LZAnorg")]
        [DisplayName("Classification Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClssfctnTp")]
        #endif
        [IsoXmlTag("ClssfctnTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareCFIIdentifier3? ClassificationType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareCFIIdentifier3? ClassificationType { get; init; } 
        #else
        public CompareCFIIdentifier3? ClassificationType { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as decimal number are matching or not.
        /// </summary>
        [IsoId("_A4HkJ8K3EeuFNp8LZAnorg")]
        [DisplayName("Quantity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Qty")]
        #endif
        [IsoXmlTag("Qty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareDecimalNumber3? Quantity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareDecimalNumber3? Quantity { get; init; } 
        #else
        public CompareDecimalNumber3? Quantity { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as active or historic currency and amount are matching or not.
        /// </summary>
        [IsoId("_A4HkKcK3EeuFNp8LZAnorg")]
        [DisplayName("Nominal Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NmnlVal")]
        #endif
        [IsoXmlTag("NmnlVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareAmountAndDirection2? NominalValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareAmountAndDirection2? NominalValue { get; init; } 
        #else
        public CompareAmountAndDirection2? NominalValue { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as collateral quality type code are matching or not.
        /// </summary>
        [IsoId("_A4HkK8K3EeuFNp8LZAnorg")]
        [DisplayName("Quality")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Qlty")]
        #endif
        [IsoXmlTag("Qlty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareCollateralQualityType3? Quality { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareCollateralQualityType3? Quality { get; init; } 
        #else
        public CompareCollateralQualityType3? Quality { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as ISO date are matching or not.
        /// </summary>
        [IsoId("_A4HkLcK3EeuFNp8LZAnorg")]
        [DisplayName("Maturity")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Mtrty")]
        #endif
        [IsoXmlTag("Mtrty")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareDate3? Maturity { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareDate3? Maturity { get; init; } 
        #else
        public CompareDate3? Maturity { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as LEI identifier are matching or not.
        /// </summary>
        [IsoId("_A4HkL8K3EeuFNp8LZAnorg")]
        [DisplayName("Issuer Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IssrId")]
        #endif
        [IsoXmlTag("IssrId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareOrganisationIdentification6? IssuerIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareOrganisationIdentification6? IssuerIdentification { get; init; } 
        #else
        public CompareOrganisationIdentification6? IssuerIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as country code are matching or not.
        /// </summary>
        [IsoId("_A4HkMcK3EeuFNp8LZAnorg")]
        [DisplayName("Issuer Country")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IssrCtry")]
        #endif
        [IsoXmlTag("IssrCtry")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareCountryCode3? IssuerCountry { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareCountryCode3? IssuerCountry { get; init; } 
        #else
        public CompareCountryCode3? IssuerCountry { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as securities lending type are matching or not.
        /// </summary>
        [IsoId("_A4HkM8K3EeuFNp8LZAnorg")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareSecuritiesLendingType3? Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareSecuritiesLendingType3? Type { get; init; } 
        #else
        public CompareSecuritiesLendingType3? Type { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the the unit prices are matching or not.
        /// </summary>
        [IsoId("_A4HkNcK3EeuFNp8LZAnorg")]
        [DisplayName("Unit Price")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnitPric")]
        #endif
        [IsoXmlTag("UnitPric")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareUnitPrice6? UnitPrice { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareUnitPrice6? UnitPrice { get; init; } 
        #else
        public CompareUnitPrice6? UnitPrice { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as true/false indicator are matching or not.
        /// </summary>
        [IsoId("_A4HkN8K3EeuFNp8LZAnorg")]
        [DisplayName("Exclusive Arrangement")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ExclsvArrgmnt")]
        #endif
        [IsoXmlTag("ExclsvArrgmnt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareTrueFalseIndicator3? ExclusiveArrangement { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareTrueFalseIndicator3? ExclusiveArrangement { get; init; } 
        #else
        public CompareTrueFalseIndicator3? ExclusiveArrangement { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as active or historic currency and amount are matching or not.
        /// </summary>
        [IsoId("_A4HkOcK3EeuFNp8LZAnorg")]
        [DisplayName("Market Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MktVal")]
        #endif
        [IsoXmlTag("MktVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareAmountAndDirection2? MarketValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareAmountAndDirection2? MarketValue { get; init; } 
        #else
        public CompareAmountAndDirection2? MarketValue { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the values defined as true/false indicator are matching or not.
        /// </summary>
        [IsoId("_A4HkO8K3EeuFNp8LZAnorg")]
        [DisplayName("Available For Collateral Reuse")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AvlblForCollReuse")]
        #endif
        [IsoXmlTag("AvlblForCollReuse")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CompareTrueFalseIndicator3? AvailableForCollateralReuse { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CompareTrueFalseIndicator3? AvailableForCollateralReuse { get; init; } 
        #else
        public CompareTrueFalseIndicator3? AvailableForCollateralReuse { get; set; } 
        #endif
        
        /// <summary>
        /// Collateral haircut, a risk control measure applied to underlying collateral whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
        /// In the case of margin lending, collateral haircut or margin requirement, a risk control measure applied to the entire collateral portfolio whereby the value of that underlying collateral is calculated as the market value of the assets reduced by a certain percentage. 
        /// Only actual values, as opposed to estimated or default values are to be reported for this attribute.
        /// </summary>
        [IsoId("_A4HkPcK3EeuFNp8LZAnorg")]
        [DisplayName("Haircut Or Margin")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="HrcutOrMrgn")]
        #endif
        [IsoXmlTag("HrcutOrMrgn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ComparePercentageRate3? HaircutOrMargin { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ComparePercentageRate3? HaircutOrMargin { get; init; } 
        #else
        public ComparePercentageRate3? HaircutOrMargin { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
