// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SearchCriteria1Choice
{
    /// <summary>
    /// Identifies a payment instrument as the search criteria for the financial institution to do the investigation.
    /// </summary>
    [IsoId("_FACTBkJ-EeGuetKibuqsKw")]
    [DisplayName("Payment Instrument")]
    public partial record PaymentInstrument : SearchCriteria1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides the card number.
        /// </summary>
        [IsoId("_Mvp5PE1KEeGAs6v-iSb2RQ")]
        [DisplayName("Card Number")]
        [IsoXmlTag("CardNb")]
        [IsoSimpleType(IsoSimpleType.Min8Max28NumericText)]
        public required IsoMin8Max28NumericText CardNumber { get; init; } 
        
        /// <summary>
        /// Identifies the authority request type as a code.
        /// </summary>
        [IsoId("_PgYUYU1KEeGAs6v-iSb2RQ")]
        [DisplayName("Authority Request Type")]
        [IsoXmlTag("AuthrtyReqTp")]
        public ValueList<AuthorityRequestType1> AuthorityRequestType { get; init; } = [];
        // ID for the above is _PgYUYU1KEeGAs6v-iSb2RQ
        
        /// <summary>
        /// Additional information, in free text form, to complement the requested information.
        /// </summary>
        [IsoId("_pJiNaV0wEeGwFY7pvwHH-g")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max500Text)]
        [StringLength(maximumLength: 500 ,MinimumLength = 1)]
        public IsoMax500Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
