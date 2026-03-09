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
namespace BeneficialStrategies.Iso20022.Choices.NCBOrPaymentBank1Choice
{
    /// <summary>
    /// Unique business identifier code used to identify the payment bank providing the information.
    /// </summary>
    [IsoId("_jA3FAe5NEeCisYr99QEiWA_1180588846")]
    [DisplayName("Payment Bank Identification")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PaymentBankIdentification : NCBOrPaymentBank1Choice_
    #else
    public partial class PaymentBankIdentification : NCBOrPaymentBank1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PaymentBankIdentification instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PaymentBankIdentification( System.String reqRelatedPartyIdentification,System.String reqResponsiblePartyIdentification )
        {
            RelatedPartyIdentification = reqRelatedPartyIdentification;
            ResponsiblePartyIdentification = reqResponsiblePartyIdentification;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique identification to unambiguously identify the party within the system.
        /// </summary>
        [IsoId("_knPM8-5NEeCisYr99QEiWA_-2106270244")]
        [DisplayName("Related Party Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RltdPtyId")]
        #endif
        [IsoXmlTag("RltdPtyId")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoBICFIIdentifier RelatedPartyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String RelatedPartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String RelatedPartyIdentification { get; init; } 
        #else
        public System.String RelatedPartyIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification of the party responsible for the maintenance of the party reference data.
        /// </summary>
        [IsoId("_knPM9O5NEeCisYr99QEiWA_1566757500")]
        [DisplayName("Responsible Party Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RspnsblPtyId")]
        #endif
        [IsoXmlTag("RspnsblPtyId")]
        [IsoSimpleType(IsoSimpleType.BICFIIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoBICFIIdentifier ResponsiblePartyIdentification { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String ResponsiblePartyIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String ResponsiblePartyIdentification { get; init; } 
        #else
        public System.String ResponsiblePartyIdentification { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
