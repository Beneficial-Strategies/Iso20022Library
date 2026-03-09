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
namespace BeneficialStrategies.Iso20022.Choices.Quantity10Choice
{
    /// <summary>
    /// Original and current value of an asset-back instrument.
    /// </summary>
    [IsoId("_WsJF5dp-Ed-ak6NoX_4Aeg_-845510532")]
    [DisplayName("Original And Current Face")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record OriginalAndCurrentFace : Quantity10Choice_
    #else
    public partial class OriginalAndCurrentFace : Quantity10Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a OriginalAndCurrentFace instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public OriginalAndCurrentFace( RestrictedFINImpliedCurrencyAndAmount reqFaceAmount,RestrictedFINImpliedCurrencyAndAmount reqAmortisedValue )
        {
            FaceAmount = reqFaceAmount;
            AmortisedValue = reqAmortisedValue;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Quantity expressed as an amount representing the face amount, that is, the principal of a debt instrument.
        /// </summary>
        [IsoId("_WsJF4dp-Ed-ak6NoX_4Aeg_-30588770")]
        [DisplayName("Face Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="FaceAmt")]
        #endif
        [IsoXmlTag("FaceAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RestrictedFINImpliedCurrencyAndAmount FaceAmount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RestrictedFINImpliedCurrencyAndAmount FaceAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RestrictedFINImpliedCurrencyAndAmount FaceAmount { get; init; } 
        #else
        public RestrictedFINImpliedCurrencyAndAmount FaceAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Quantity expressed as an amount representing the current amortised face amount of a bond, for example, a periodic reduction/increase of a bond&apos;s principal amount.
        /// </summary>
        [IsoId("_WsJF4tp-Ed-ak6NoX_4Aeg_1660909971")]
        [DisplayName("Amortised Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AmtsdVal")]
        #endif
        [IsoXmlTag("AmtsdVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required RestrictedFINImpliedCurrencyAndAmount AmortisedValue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required RestrictedFINImpliedCurrencyAndAmount AmortisedValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public RestrictedFINImpliedCurrencyAndAmount AmortisedValue { get; init; } 
        #else
        public RestrictedFINImpliedCurrencyAndAmount AmortisedValue { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
