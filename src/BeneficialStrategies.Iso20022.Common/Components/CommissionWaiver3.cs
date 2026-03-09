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
/// Non-enforcement of the right to all or part of a commission by the party entitled to the commission.
/// </summary>
[IsoId("_QbTZ-dp-Ed-ak6NoX_4Aeg_-841172268")]
[DisplayName("Commission Waiver")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommissionWaiver3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommissionWaiver3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommissionWaiver3( WaivingInstruction1Code reqInstructionBasis,System.String reqExtendedInstructionBasis,System.Decimal reqWaivedRate )
    {
        InstructionBasis = reqInstructionBasis;
        ExtendedInstructionBasis = reqExtendedInstructionBasis;
        WaivedRate = reqWaivedRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Form of the rebate, eg, cash.
    /// </summary>
    [IsoId("_QbTZ-tp-Ed-ak6NoX_4Aeg_-841172225")]
    [DisplayName("Instruction Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstrBsis")]
    #endif
    [IsoXmlTag("InstrBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required WaivingInstruction1Code InstructionBasis { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required WaivingInstruction1Code InstructionBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public WaivingInstruction1Code InstructionBasis { get; init; } 
    #else
    public WaivingInstruction1Code InstructionBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Form of the rebate, eg, cash.
    /// </summary>
    [IsoId("_QbTZ-9p-Ed-ak6NoX_4Aeg_-1880085102")]
    [DisplayName("Extended Instruction Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XtndedInstrBsis")]
    #endif
    [IsoXmlTag("XtndedInstrBsis")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExtended350Code ExtendedInstructionBasis { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ExtendedInstructionBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ExtendedInstructionBasis { get; init; } 
    #else
    public System.String ExtendedInstructionBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Proportion of the commission that is waived, ie, if the commission is 5% and half is waived, 2.5% should be stated in this field.
    /// </summary>
    [IsoId("_QbTZ_Np-Ed-ak6NoX_4Aeg_-841172243")]
    [DisplayName("Waived Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WvdRate")]
    #endif
    [IsoXmlTag("WvdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate WaivedRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal WaivedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal WaivedRate { get; init; } 
    #else
    public System.Decimal WaivedRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}
