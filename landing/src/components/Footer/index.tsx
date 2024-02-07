import { Row, Col } from "antd";
import { withTranslation } from "react-i18next";
import { SvgIcon } from "../../common/SvgIcon";
import Container from "../../common/Container";

import i18n from "i18next";
import {
  FooterSection,
  Title,
  NavLink,
  Extra,
  LogoContainer,
  Para,
  Large,
  Chat,
  Empty,
 // FooterContainer,
  Language,
  Label,
  LanguageSwitch,
  LanguageSwitchContainer,
} from "./styles";


const Footer = ({ t }: any) => {
  const handleChange = (language: string) => {
    i18n.changeLanguage(language);
  };



  return (
    <>
      <FooterSection>
        <Container>
          <Row justify="space-between">
            <Col lg={6} md={6} sm={12} xs={12}>
              <Title>{t("Company")}</Title>
              <Large left="true" to="/">
                {t("About")}
              </Large>
              <Large left="true" to="/">
                {t("Blog")}
              </Large>
              <Large left="true" to="/">
                {t("Press")}
              </Large>
            </Col>
            <Col lg={6} md={6} sm={12} xs={12}>
              <Title>{t("Address")}</Title>
              <Para>Paris, France</Para>
            </Col>
            <Col lg={6} md={6} sm={12} xs={12}>
            <Title> {t("Our Team")}</Title>
              <Large left="true" to="/">
                <a href="https://www.linkedin.com/in/pkkirsch/">
                {t("Kelly KIRSCH - Co-Founder")}
                </a>
              </Large>
              <Large left="true" to="/">
              <a href="https://www.linkedin.com/in/mavrick-galand/">
                {t("Mavrick GALAND - Co-Founder")}
                </a>
              </Large>
              <Large left="true" to="/">
              <a href="https://www.linkedin.com/in/oualid-a-775291147/">
                {t("Oualid ANKIR - Co-Founder")}
                </a>
              </Large>
              <Large left="true" to="/">
              <a href="https://www.linkedin.com/in/ayoub-benhamdi-a4abaa19b/">
                {t("Ayoub BENHAMDI - Co-Founder")}
                </a>
              </Large>
            </Col>
            <Col lg={6} md={6} sm={12} xs={12}>
              <Language>{t("Contact")}</Language>
              <Large to="/">{t("Tell us everything")}</Large>
              <Para>
                {t(`Do you have any question? Feel free to reach out.`)}
              </Para>
              <a href="mailto:@gmail.com">
                <Chat>{t(`Let's Chat`)}</Chat>
              </a>
            </Col>
            <Col lg={6} md={6} sm={12} xs={12}>
              
              <LanguageSwitchContainer>
                <LanguageSwitch onClick={() => handleChange("en")}>
                  <SvgIcon
                    src="flagluklogo.png"
                    aria-label="homepage"
                    width="25px"
                    height="25px"
                  />
                </LanguageSwitch>
                <LanguageSwitch onClick={() => handleChange("es")}>
                  <SvgIcon
                    src="spain.svg"
                    aria-label="homepage"
                    width="25px"
                    height="25px"
                  />
                </LanguageSwitch>
              </LanguageSwitchContainer>
            </Col>
          </Row>
        </Container>
      </FooterSection>
      <Extra>
        <Container border={true}>
          <Row
            justify="space-between"
            align="middle"
            style={{ paddingTop: "3rem" }}
          >
            <NavLink to="/">
              <LogoContainer>
                <SvgIcon
                  src="logo.svg"
                  aria-label="homepage"
                  width="125px"
                  height="20px"
                />
              </LogoContainer>
            </NavLink>
          </Row>
        </Container>
      </Extra>
    </>
  );
};

export default withTranslation()(Footer);
