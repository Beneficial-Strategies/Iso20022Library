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
namespace BeneficialStrategies.Iso20022.Choices.ReservationOrError7Choice
{
    /// <summary>
    /// Requested information on the limit.
    /// </summary>
    [IsoId("_T9Cs0ZliEeeE1Ya-LgRsuQ")]
    [DisplayName("Reservation")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Reservation : ReservationOrError7Choice_
    #else
    public partial class Reservation : ReservationOrError7Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Reservation instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Reservation( Amount2Choice_ reqAmount )
        {
            Amount = reqAmount;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Amount of money of the limit, expressed in an eligible currency.
        /// </summary>
        [IsoId("_UFVtM5liEeeE1Ya-LgRsuQ")]
        [DisplayName("Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Amt")]
        #endif
        [IsoXmlTag("Amt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Amount2Choice_ Amount { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Amount2Choice_ Amount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Amount2Choice_ Amount { get; init; } 
        #else
        public Amount2Choice_ Amount { get; set; } 
        #endif
        
        /// <summary>
        /// Status of the limit, such as enabled or disabled.
        /// </summary>
        [IsoId("_UFVtNZliEeeE1Ya-LgRsuQ")]
        [DisplayName("Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Sts")]
        #endif
        [IsoXmlTag("Sts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReservationStatus1Choice_? Status { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReservationStatus1Choice_? Status { get; init; } 
        #else
        public ReservationStatus1Choice_? Status { get; set; } 
        #endif
        
        /// <summary>
        /// Date and time at which the reservation becomes effective.
        /// </summary>
        [IsoId("_UFVtN5liEeeE1Ya-LgRsuQ")]
        [DisplayName("Start Date Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="StartDtTm")]
        #endif
        [IsoXmlTag("StartDtTm")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DateAndDateTime2Choice_? StartDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DateAndDateTime2Choice_? StartDateTime { get; init; } 
        #else
        public DateAndDateTime2Choice_? StartDateTime { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
