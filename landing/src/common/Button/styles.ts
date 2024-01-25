import styled,{keyframes} from "styled-components";

export const Button1 = styled.button`
background: ${(p) => p.color || "#2e186a"};
color: ${(p) => (p.color ? "#2E186A" : "#fff")};
font-size: 1rem;
font-weight: 700;
width: 100%;
border: 1px solid #2E186A;
border-radius: 4px;
padding: 13px 0;
cursor: pointer;
margin-top: 0.625rem;
max-width: 180px;
transition: all 0.3s ease-in-out;
box-shadow: 0 16px 30px rgb(23 31 114 / 20%);

&:hover,
&:active,
&:focus {
  color: #fff;
  border: 1px solid #FDC2BE;
  background-color: #FDC2BE;
}
`

const jelloAnimation = keyframes`
  0% {
    transform: scale3d(1, 1, 1);
  }

  30% {
    transform: scale3d(1.25, 0.75, 1);
  }

  40% {
    transform: scale3d(0.75, 1.25, 1);
  }

  50% {
    transform: scale3d(1.15, 0.85, 1);
  }

  65% {
    transform: scale3d(0.95, 1.05, 1);
  }

  75% {
    transform: scale3d(1.05, 0.95, 1);
  }

  100% {
    transform: scale3d(1, 1, 1);
  }
`;

export const Btn =styled.button`
  position: relative;
  width: 150px;
  height: 55px;
  border-radius: 45px;
  border: none;
  background-color: #ff5a98;
  color: white;
  box-shadow: 0px 10px 10px #ff5a98 inset,
    0px 5px 10px #ff5a98,
    0px -10px 10px #ff5a98 inset;
  cursor: pointer;
  display: center;
  align-items: center;
  justify-content: center;

  &::before,
  &::after {
    width: 70%;
    height: 2px;
    position: absolute;
    content: "";
    filter: blur(1px);
    border-radius: 50%;
  }

  &::before {
    background-color: rgba(250, 250, 250, 0.678);
    top: 7px;
  }

  &::after {
    background-color: rgba(250, 250, 250, 0.137);
    bottom: 7px;
  }

  &:hover {
    animation: ${jelloAnimation} 0.9s both;
  }
`;
;
export const Button3 =styled.button
`
`
;