import { withTranslation } from "react-i18next";
import { Container, TextWrapper, Content, Blockstyled  } from "./styles";
import "./styles";

interface Props {
  title: string;
  content: string;
  t: any;
}

const Block = ({ title, content, t }: Props) => {
  return (
    <Blockstyled>
    
      <h6>{t(title)}</h6>
      <TextWrapper>
        <Content>{t(content)}</Content>
      </TextWrapper>
    </Blockstyled>
  );
};

export default withTranslation()(Block);
