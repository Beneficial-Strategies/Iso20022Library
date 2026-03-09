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
/// Provides further details related to a direct debit mandate signed between the creditor and the debtor.
/// </summary>
[IsoId("_rKvJEdppEeearpaEPXv9UA")]
[DisplayName("Mandate Related Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MandateRelatedInformation13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MandateRelatedInformation13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MandateRelatedInformation13( System.String reqMandateIdentification )
    {
        MandateIdentification = reqMandateIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the creditor, to unambiguously identify the mandate.
    /// </summary>
    [IsoId("_rTxJQ9ppEeearpaEPXv9UA")]
    [DisplayName("Mandate Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtId")]
    #endif
    [IsoXmlTag("MndtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MandateIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MandateIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MandateIdentification { get; init; } 
    #else
    public System.String MandateIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the direct debit mandate has been signed by the debtor.
    /// </summary>
    [IsoId("_rTxJRdppEeearpaEPXv9UA")]
    [DisplayName("Date Of Signature")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtOfSgntr")]
    #endif
    [IsoXmlTag("DtOfSgntr")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? DateOfSignature { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? DateOfSignature { get; init; } 
    #else
    public System.DateOnly? DateOfSignature { get; set; } 
    #endif
    
    /// <summary>
    /// Image of scanned signed mandate.
    /// </summary>
    [IsoId("_IYrp8NpqEeearpaEPXv9UA")]
    [DisplayName("Mandate Image")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MndtImg")]
    #endif
    [IsoXmlTag("MndtImg")]
    [IsoSimpleType(IsoSimpleType.Max2MBBinary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2MBBinary? MandateImage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? MandateImage { get; init; } 
    #else
    public System.Byte[]? MandateImage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
