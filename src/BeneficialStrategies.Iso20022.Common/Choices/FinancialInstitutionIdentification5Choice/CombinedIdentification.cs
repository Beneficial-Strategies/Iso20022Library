// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstitutionIdentification5Choice
{
    /// <inheritdoc cref="ICombinedIdentification"/>
    [IsoId("_TFnrItp-Ed-ak6NoX_4Aeg_1781480692")]
    [DisplayName("Combined Identification")]
    [IsoXmlTag("CmbndId")]
    public partial record CombinedIdentification : FinancialInstitutionIdentification5Choice_
    {
        /// <inheritdoc cref="ICombinedIdentification.BIC"/>
        [IsoId("_TFehMdp-Ed-ak6NoX_4Aeg_696920663")]
        [DisplayName("BIC")]
        [IsoXmlTag("BIC")]
        [IsoSimpleType(IsoSimpleType.BICIdentifier)]
        public IsoBICIdentifier? BIC { get; init; }

        /// <inheritdoc cref="ICombinedIdentification.ClearingSystemMemberIdentification"/>
        [IsoId("_TFehMtp-Ed-ak6NoX_4Aeg_696921670")]
        [DisplayName("Clearing System Member Identification")]
        [IsoXmlTag("ClrSysMmbId")]
        public ClearingSystemMemberIdentification3Choice_? ClearingSystemMemberIdentification { get; init; }

        /// <inheritdoc cref="ICombinedIdentification.Name"/>
        [IsoId("_TFehM9p-Ed-ak6NoX_4Aeg_696922156")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max70Text)]
        [StringLength(maximumLength: 70, MinimumLength = 1)]
        public IsoMax70Text? Name { get; init; }

        /// <inheritdoc cref="ICombinedIdentification.PostalAddress"/>
        [IsoId("_TFehNNp-Ed-ak6NoX_4Aeg_696923981")]
        [DisplayName("Postal Address")]
        [IsoXmlTag("PstlAdr")]
        public PostalAddress1? PostalAddress { get; init; }

        /// <inheritdoc cref="ICombinedIdentification.ProprietaryIdentification"/>
        [IsoId("_TFehNdp-Ed-ak6NoX_4Aeg_-1274464914")]
        [DisplayName("Proprietary Identification")]
        [IsoXmlTag("PrtryId")]
        public GenericIdentification3? ProprietaryIdentification { get; init; }
    }
}
