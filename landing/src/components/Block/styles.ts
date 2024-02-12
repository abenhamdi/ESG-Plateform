import styled from "styled-components";

export const Content = styled("p")`
  margin-top: 1.5rem;
`;

export const Container = styled("div")`
  position: relative;
  max-width: 700px;
`;

export const TextWrapper = styled("div")`
  display: flex;
  border-radius: 3rem;
  max-width: 400px;
`;
export const ContentWrapper = styled("div")`
  position: relative;
  max-width: 540px;
  box-shadow: -10px 30px 11px 28px rgba(0,0,0,0.15);

  @media only screen and (max-width: 575px) {
    padding-bottom: 4rem;
  }
`
;
export const Blockstyled = styled("div")`
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  `;