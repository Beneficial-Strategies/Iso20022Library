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
/// Attributes of a pension.
/// </summary>
[IsoId("_7NcYcTOTEeqLMcD_sEa8Xw")]
[DisplayName("Pension")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Pension4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_7lP0cTOTEeqLMcD_sEa8Xw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PensionPolicy1? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PensionPolicy1? Identification { get; init; } 
    #else
    public PensionPolicy1? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of pension policy, plan or scheme.
    /// </summary>
    [IsoId("_7lP0czOTEeqLMcD_sEa8Xw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PensionSchemeType2Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PensionSchemeType2Choice_? Type { get; init; } 
    #else
    public PensionSchemeType2Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Scope of the pension policy, plan or scheme transfer.
    /// </summary>
    [IsoId("_7lP0dTOTEeqLMcD_sEa8Xw")]
    [DisplayName("Transfer Scope")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfScp")]
    #endif
    [IsoXmlTag("TrfScp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PensionTransferScope1Choice_? TransferScope { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PensionTransferScope1Choice_? TransferScope { get; init; } 
    #else
    public PensionTransferScope1Choice_? TransferScope { get; set; } 
    #endif
    
    /// <summary>
    /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
    /// </summary>
    [IsoId("_7lP0dzOTEeqLMcD_sEa8Xw")]
    [DisplayName("Tax Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRef")]
    #endif
    [IsoXmlTag("TaxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxReference1? TaxReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReference1? TaxReference { get; init; } 
    #else
    public TaxReference1? TaxReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the drawdown.
    /// </summary>
    [IsoId("_7lP0eTOTEeqLMcD_sEa8Xw")]
    [DisplayName("Drawdown Tranche Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrwdwnTrchId")]
    #endif
    [IsoXmlTag("DrwdwnTrchId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DrawdownTrancheIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DrawdownTrancheIdentification { get; init; } 
    #else
    public System.String? DrawdownTrancheIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_7lP0ezOTEeqLMcD_sEa8Xw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
