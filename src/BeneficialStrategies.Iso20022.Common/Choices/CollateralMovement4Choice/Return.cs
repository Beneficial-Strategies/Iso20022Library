// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralMovement4Choice
{
    /// <summary>
    /// Provides the collateral movement direction that is a return only.
    /// </summary>
    [IsoId("_yckWY4FvEeWtPe6Crjmeug")]
    [DisplayName("Return")]
    [IsoXmlTag("Rtr")]
    public record Return : CollateralMovement4Choice_
    {
        /// <summary>
        /// Specifies the reference to the unambiguous identification of the margin call request.
        /// </summary>
        [IsoId("_zIwuAYFvEeWtPe6Crjmeug")]
        [DisplayName("Margin Call Request Identification")]
        [IsoXmlTag("MrgnCallReqId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text MarginCallRequestIdentification { get; init; }

        /// <summary>
        /// Specifies the reference to the unambiguous identification of the margin call response.
        /// </summary>
        [IsoId("_zIwuA4FvEeWtPe6Crjmeug")]
        [DisplayName("Margin Call Response Identification")]
        [IsoXmlTag("MrgnCallRspnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? MarginCallResponseIdentification { get; init; }

        /// <summary>
        /// Specifies the standard settlement instructions.
        /// </summary>
        [IsoId("_zIwuBYFvEeWtPe6Crjmeug")]
        [DisplayName("Standard Settlement Instructions")]
        [IsoXmlTag("StdSttlmInstrs")]
        [IsoSimpleType(IsoSimpleType.Max140Text)]
        [StringLength(maximumLength: 140, MinimumLength = 1)]
        public IsoMax140Text? StandardSettlementInstructions { get; init; }

        /// <summary>
        /// Specifies the reference to the unambiguous identification of the collateral proposal response (in case of counter proposal).
        /// </summary>
        [IsoId("_zIwuB4FvEeWtPe6Crjmeug")]
        [DisplayName("Collateral Proposal Response Identification")]
        [IsoXmlTag("CollPrpslRspnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? CollateralProposalResponseIdentification { get; init; }

        /// <summary>
        /// Collateral type is securities.
        /// </summary>
        [IsoId("_zIwuCYFvEeWtPe6Crjmeug")]
        [DisplayName("Securities Collateral")]
        [IsoXmlTag("SctiesColl")]
        public SecuritiesCollateral5? SecuritiesCollateral { get; init; }

        /// <summary>
        /// Collateral type is cash.
        /// </summary>
        [IsoId("_zIwuC4FvEeWtPe6Crjmeug")]
        [DisplayName("Cash Collateral")]
        [IsoXmlTag("CshColl")]
        public CashCollateral2? CashCollateral { get; init; }

        /// <summary>
        /// Collateral type is other than securities or cash for example letter of credit.
        /// </summary>
        [IsoId("_zIwuDYFvEeWtPe6Crjmeug")]
        [DisplayName("Other Collateral")]
        [IsoXmlTag("OthrColl")]
        public OtherCollateral5? OtherCollateral { get; init; }
    }
}
