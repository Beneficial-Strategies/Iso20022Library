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
namespace BeneficialStrategies.Iso20022.Choices.SearchCriteria1Choice
{
    /// <summary>
    /// Identifies a payment instrument as the search criteria for the financial institution to do the investigation.
    /// </summary>
    [IsoId("_FACTBkJ-EeGuetKibuqsKw")]
    [DisplayName("Payment Instrument")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record PaymentInstrument : SearchCriteria1Choice_
    #else
    public partial class PaymentInstrument : SearchCriteria1Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a PaymentInstrument instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public PaymentInstrument( System.String reqCardNumber )
        {
            CardNumber = reqCardNumber;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Provides the card number.
        /// </summary>
        [IsoId("_Mvp5PE1KEeGAs6v-iSb2RQ")]
        [DisplayName("Card Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CardNb")]
        #endif
        [IsoXmlTag("CardNb")]
        [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMin8Max28NumericText CardNumber { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String CardNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String CardNumber { get; init; } 
        #else
        public System.String CardNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Identifies the authority request type as a code.
        /// </summary>
        [IsoId("_PgYUYU1KEeGAs6v-iSb2RQ")]
        [DisplayName("Authority Request Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AuthrtyReqTp")]
        #endif
        [IsoXmlTag("AuthrtyReqTp")]
        public ValueList<AuthorityRequestType1> AuthorityRequestType { get; init; } = new ValueList<AuthorityRequestType1>(){}; // Warning: Don't know multiplicity.
        // ID for the above is _PgYUYU1KEeGAs6v-iSb2RQ
        
        /// <summary>
        /// Additional information, in free text form, to complement the requested information.
        /// </summary>
        [IsoId("_pJiNaV0wEeGwFY7pvwHH-g")]
        [DisplayName("Additional Information")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlInf")]
        #endif
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max500Text)]
        [StringLength(maximumLength: 500 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax500Text? AdditionalInformation { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? AdditionalInformation { get; init; } 
        #else
        public System.String? AdditionalInformation { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
