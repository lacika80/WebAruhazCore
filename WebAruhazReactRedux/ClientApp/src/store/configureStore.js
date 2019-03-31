import { applyMiddleware, combineReducers, compose, createStore } from 'redux';
import thunk from 'redux-thunk';
import { routerReducer, routerMiddleware } from 'react-router-redux';
import * as Counter from './Counter';
import * as WeatherForecasts from './WeatherForecasts';
import itemsReducer from '../_reducers/items.reducers';
import basketReducer from '../_reducers/basket.reducers';
import filtersReducer from '../_reducers/filters.reducers';
import basicsReducer from '../_reducers/basics.reducers';
import { createBrowserHistory} from 'history';
import { authentication } from '../_reducers/authentication.reducers';
import { registration } from '../_reducers/registration.reducers';

export default function configureStore (history, initialState) {
  const reducers = {
    counter: Counter.reducer,
    weatherForecasts: WeatherForecasts.reducer
  };

  const middleware = [
    thunk,
    routerMiddleware(history)
  ];

  // In development, use the browser's Redux dev tools extension if installed
  const enhancers = [];
  const isDevelopment = process.env.NODE_ENV === 'development';
  if (isDevelopment && typeof window !== 'undefined' && window.devToolsExtension) {
    enhancers.push(window.devToolsExtension());
  }

  const rootReducer = combineReducers({
    ...reducers,
    routing: routerReducer,
    items: itemsReducer,
    filters: filtersReducer,
    basics: basicsReducer,
    basket: basketReducer,
    authentication,
    registration
  });

  return createStore(
    rootReducer,
    initialState,
    compose(applyMiddleware(...middleware), ...enhancers),
  );

}

// //store creation  - parancsot ad ki a state... store változtatás emgkezdéséhez
// const store = createStore(
//   combineReducers({
//       items: itemsReducer,
//       filters: filtersReducer
//   })
// );