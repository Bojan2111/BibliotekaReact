import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import Biblioteka from "./components/Biblioteka";

const AppRoutes = [
  {
    index: true,
    element: <Home />
  },
  {
    path: '/counter',
    element: <Counter />
  },
  {
    path: '/fetch-data',
    element: <FetchData />
   },
   {
    path: '/biblioteka',
    element: <Biblioteka />
   }
];

export default AppRoutes;
