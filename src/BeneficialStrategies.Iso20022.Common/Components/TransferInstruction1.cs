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
/// Provides further information required for the account switch.
/// </summary>
[IsoId("_AU8gYUz5EeepdbMfWGyv3Q")]
[DisplayName("Transfer Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferInstruction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferInstruction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferInstruction1( System.String reqCode )
    {
        Code = reqCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether a payment arrangement is transferable.
    /// Usage: Default value for TransferIndicator is false.
    /// </summary>
    [IsoId("_e2fXIEz5EeepdbMfWGyv3Q")]
    [DisplayName("Transfer Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfInd")]
    #endif
    [IsoXmlTag("TrfInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TransferIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferIndicator { get; init; } 
    #else
    public System.String? TransferIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies an additional parameter to be applied to the requested transaction schedule.
    /// </summary>
    [IsoId("_AjO0AUz5EeepdbMfWGyv3Q")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Code { get; init; } 
    #else
    public System.String Code { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies an additional parameter to be applied to the transaction schedule in a proprietary format.
    /// </summary>
    [IsoId("_AjO0A0z5EeepdbMfWGyv3Q")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Proprietary { get; init; } 
    #else
    public System.String? Proprietary { get; set; } 
    #endif
    
    /// <summary>
    /// The date and time at which the event specified by Code commences.
    /// </summary>
    [IsoId("_AjO0B0z5EeepdbMfWGyv3Q")]
    [DisplayName("Start Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDtTm")]
    #endif
    [IsoXmlTag("StartDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? StartDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? StartDateTime { get; init; } 
    #else
    public System.DateTime? StartDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// The date on which the event specified by Code commences.
    /// </summary>
    [IsoId("_AjO0CUz5EeepdbMfWGyv3Q")]
    [DisplayName("Start Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDt")]
    #endif
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? StartDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? StartDate { get; init; } 
    #else
    public System.DateOnly? StartDate { get; set; } 
    #endif
    
    /// <summary>
    /// Additional switch parameters in a free text format.
    /// </summary>
    [IsoId("_AjO0C0z5EeepdbMfWGyv3Q")]
    [DisplayName("Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Desc")]
    #endif
    [IsoXmlTag("Desc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Description { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Description { get; init; } 
    #else
    public System.String? Description { get; set; } 
    #endif
    
    
    #nullable disable
    
}
