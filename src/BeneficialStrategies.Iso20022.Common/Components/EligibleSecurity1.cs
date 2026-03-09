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
/// Provides details of the eligible securities as defined in the collateral reference data.
/// </summary>
[IsoId("_jARPJO5NEeCisYr99QEiWA_-82514142")]
[DisplayName("Eligible Security")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EligibleSecurity1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EligibleSecurity1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EligibleSecurity1( System.String reqSecurityIdentification,string reqCollateralisationCurrency,NCBOrPaymentBank1Choice_ reqPartyIdentification )
    {
        SecurityIdentification = reqSecurityIdentification;
        CollateralisationCurrency = reqCollateralisationCurrency;
        PartyIdentification = reqPartyIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of a security by an ISIN.
    /// </summary>
    [IsoId("_jAaZEO5NEeCisYr99QEiWA_1441162586")]
    [DisplayName("Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyId")]
    #endif
    [IsoXmlTag("SctyId")]
    [IsoSimpleType(IsoSimpleType.ISINIdentifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISINIdentifier SecurityIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SecurityIdentification { get; init; } 
    #else
    public System.String SecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Currency which may be processed by the system. A system may process transactions in a single currency or in multiple currencies.
    /// </summary>
    [IsoId("_jAaZEe5NEeCisYr99QEiWA_-1516085313")]
    [DisplayName("Collateralisation Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollstnCcy")]
    #endif
    [IsoXmlTag("CollstnCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode CollateralisationCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string CollateralisationCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string CollateralisationCurrency { get; init; } 
    #else
    public string CollateralisationCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the party for which the eligible security is defined.
    /// </summary>
    [IsoId("_jAaZEu5NEeCisYr99QEiWA_-423808340")]
    [DisplayName("Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PtyId")]
    #endif
    [IsoXmlTag("PtyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NCBOrPaymentBank1Choice_ PartyIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NCBOrPaymentBank1Choice_ PartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NCBOrPaymentBank1Choice_ PartyIdentification { get; init; } 
    #else
    public NCBOrPaymentBank1Choice_ PartyIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
